using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace Hidder
{
    class Hidder
    {
        private String inpFile;
        private String outFile;
        private String outMainFolder = "\\Extracted"; //папка распаковки
        private String pathHide;
        private String pass = "hidd3r appl1cation"; //Пароль по умолчанию
        private String passSalt = "hidd3r appl1cation"; //Кусок, который добавляется к паролю пользователя
        private bool passGood = true;
        //private byte[] md5Pass;// = { 0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15};
        //Начальные/конечные байты, по которым программа прячет файлы и извлекает
            private byte[] startBytes = { 1, 2, 3, 4, 0, 5, 6, 7, 8, 33, 72, 105, 100, 100, 101, 114, 95, 115, 116, 97, 114, 116, 33 };
        private byte[] endBytes = { 33, 72, 105, 100, 100, 101, 114, 95, 101, 110, 100, 33, 9, 10, 11, 12, 0, 13, 14, 15, 16 };

        private byte[] startPath = { 1, 2, 3, 4, 0, 5, 6, 7, 8, 33, 112, 97, 116, 104, 95, 115, 116, 97, 114, 116, 33 };
        private byte[] endPath = { 33, 112, 97, 116, 104, 95, 101, 110, 100, 33, 9, 10, 11, 12, 0, 13, 14, 15, 16 };

        //private byte[] DirectoryFind = { 0 };
        private byte[] DirectoryStart = { 1, 2, 3, 4, 0, 5, 6, 7, 8, 33, 104, 105, 100, 100, 101, 114, 95, 100, 105, 114, 101, 99, 116, 111, 114, 121, 33 };
        private byte[] DirectoryEnd = { 33, 104, 105, 100, 100, 101, 114, 95, 100, 105, 114, 101, 99, 116, 111, 114, 121, 95, 101, 110, 100, 33, 9, 10, 11, 12, 0, 13, 14, 15, 16 };
        //private byte[] endBlock = { 0,0 };

        //Конструктор упаковщика/распоковщика
        public Hidder(String inputFile, String outputFile = "encrypted", String pathToHide = "")
        {
            //md5Pass = CalculateMD5Hash(pass);
            inpFile = inputFile;
            outFile = outputFile;
            pathHide = pathToHide;
            passGood = true;            
        }

        //Метод тестирования шифрования XOR
        private void testEncryption()
        {
            int size = 256 * 256;
            byte[] allCoombs = new byte[size];
            byte[] EncryptedXor = new byte[size];
            byte[] DecryptedXor = new byte[size];
            for(byte byteXor=0;byteXor<256;byteXor++)
            {                
                for (byte PosArr = 0; PosArr < 256; PosArr++)
                {
                    allCoombs[PosArr + byteXor * 256] = byteXor;
                    EncryptedXor[PosArr + byteXor * 256] = (byte)(allCoombs[PosArr + byteXor * 256]^PosArr);
                    DecryptedXor[PosArr + byteXor * 256] = (byte)(EncryptedXor[PosArr + byteXor * 256] ^ PosArr);
                    if(allCoombs[PosArr + byteXor * 256] != DecryptedXor[PosArr + byteXor * 256])
                    {
                        Console.WriteLine(allCoombs[PosArr + byteXor * 256].ToString()+"^"+PosArr.ToString()+" Error");
                    }
                    if (PosArr == 255) break;
                }
                if (byteXor == 255) break;
            }
        }

        //Методы получения и установления параметров объекта
        public void setInputFile(String pathToFile)
        {
            inpFile = pathToFile;
        }

        public String getInputFile()
        {
            return inpFile;
        }

        public void setOutputFile(String pathToOutput)
        {
            outFile = pathToOutput;
        }

        public String getOutputFile()
        {
            return outFile;
        }

        public void setPathToHide(String pathToHide)
        {
            pathHide = pathToHide;
        }

        public String getPathToHide()
        {
            return pathHide;
        }

        public void setPassword(String password)
        {
            pass = @passSalt + " " + @password;//.ToLower();
            //Debug.WriteLine(pass);
            //md5Pass = CalculateMD5Hash(pass);
        }

        //Проверка наличия файлов на жёстком диске
        private bool validFilesToHide(bool isDirectory = false)
        {
            bool valid = false;
            if (System.IO.File.Exists(inpFile))
            {
                if (((!isDirectory) && (System.IO.File.Exists(pathHide)))
                    || ((isDirectory) && (System.IO.Directory.Exists(pathHide))))
                {
                    valid = true;
                }
            }
            return valid;
        }

        //Функция шифрования байтов
        private byte[] enc(byte[] bytes, int startFrom = 0)
        {
            int k = startFrom;            
            for (long i = 0; i < bytes.LongLength; i++)
            {                
                byte doOn = (byte)pass[k];
                k = (k + 1) % pass.Length;                
                if(bytes[i]!=0 && bytes[i] != doOn)
                    bytes[i] = (byte)(bytes[i] ^ doOn);
            }
            return bytes;
        }

        private byte[] CalculateHash(string input)
        {
            // Вычисляем байты хэша MD5 от пароля 
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.Unicode.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);
            // convert byte array to hex string
            /*StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }*/
            return hash;//sb.ToString();
        }

        public bool HidingStatus()
        {
            return HidingNow;
        }

        public int getCountFilesToHide()
        {
            return countFilesToHide;
        }

        public int getHidedSuccess()
        {
            return hidedSuccess;
        }

        public int getHidedFoldersSuccess()
        {
            return hidedFoldersSuccess;
        }

        public string getLastHiding()
        {
            return pathOfFileToHide;
        }

        //Получения прогресса упаковщика в процентах
        public int getHidingProgress()
        {
            int progress = 0;
            if (countFilesToHide != 0)
                progress = (int)(((float)hidedSuccess / countFilesToHide) * 100);
            if (progress == 100 && HidingNow)
                progress = 99;
            return progress;
        }

        private int countFilesToHide = 0;
        private int hidedSuccess = 0;
        private int hidedFoldersSuccess = 0;
        private bool HidingNow = false;
        private string pathOfFileToHide = "";

        //Запуск упаковщика в новом потоке
        public void hideFilesAtNewThread(bool isDirectory = false)
        {
            Thread threadHideFiles = new Thread(() => hideFiles(isDirectory));
            threadHideFiles.IsBackground = true;

            threadHideFiles.Start();
        }

        //Проверка найденного hash'а в файле
        //с hash'ом высчитанным из пароля в данный момент
        public bool passwordIsTrue(byte[] passwordBytes)
        {
            bool isTrue = true;
            byte[] hashPass = CalculateHash(pass);
            //Console.WriteLine(hashPass.LongLength);
            if (passwordBytes.LongLength >= hashPass.LongLength)
            {
                for(int posPassByte=0;posPassByte<hashPass.LongLength;posPassByte++)
                {
                    //Console.WriteLine("\n\nSomeMagic: "+hashPass[posPassByte].ToString() + " " + passwordBytes[posPassByte].ToString());
                    //Console.WriteLine((hashPass[posPassByte]==passwordBytes[posPassByte]).ToString());
                    if (hashPass[posPassByte]!=passwordBytes[posPassByte])
                    {
                        
                        isTrue = false;
                        break;
                    }
                }
            }
            else isTrue = false;
            return isTrue;
        }

        public bool CorrectPass()
        {
            return passGood;
        }

        //Упаковщик
        public void hideFiles(bool isDirectory = false)
        {
            //Debug.WriteLine(CalculateMD5Hash(pass));            
            bool status = false;            
            HidingNow = true;
            hidedSuccess = 0;
            hidedFoldersSuccess = 0;
            
            string[] files = new string[0];            
            string[] directories = new string[0];
            string pathCut = Path.GetDirectoryName(pathHide);
            if (isDirectory)
            {
                //Ищем пути всех файлов и папок
                files = Directory.GetFiles(pathHide, "*", SearchOption.AllDirectories);
                directories = System.IO.Directory.GetDirectories(@pathHide, "*", System.IO.SearchOption.AllDirectories);
            }
            else files = new string[1] { pathHide};            
            //Если есть что прятать (больше 0 файлов или больше 0 папок)
            //То копируем основной файл
            if(files.LongLength>0 || directories.LongLength>0)
            {
                File.Copy(inpFile, outFile, true);
            }
            //Проходим по всем путям и всё прячем в основном файле
            countFilesToHide = files.Length;            
            for (long fileNum=0;fileNum<files.LongLength;fileNum++)
            {
                if(hideFile(files[fileNum], pathCut))
                    hidedSuccess++;
            }
            for (long folderNum = 0; folderNum < directories.LongLength; folderNum++)
            {
                if(hideFolder(directories[folderNum], pathCut))
                    hidedFoldersSuccess++;
            }
            //Console.WriteLine(pathCut);
                        
            HidingNow = false;                            
            //return status;
        }

        //Функция которая прячет файл по заданному пути
        private bool hideFile(string pathFile,string pathCut = "")
        {
            bool hideOK = true;
            //Берём байты файла
            byte[] fileBytes = readFileAllBytes(pathFile);
            //Шифруем их
            fileBytes = enc(fileBytes);
            //Вычисляем hash пароля
            byte[] hashPass = CalculateHash(pass);

            //Обрезаем путь файла и шифруем его
            string pathCutted = pathFile.Replace(pathCut, "");            
            byte[] unicodeBytesOfPath = Encoding.Unicode.GetBytes(pathCutted);
            unicodeBytesOfPath = enc(unicodeBytesOfPath);

            //Добавляем метки, шифрованный путь и шифрованный файл
            appendByteArrayToFile(startBytes, outFile);
            appendByteArrayToFile(hashPass, outFile);
            appendByteArrayToFile(startPath, outFile);
            appendByteArrayToFile(unicodeBytesOfPath, outFile);
            appendByteArrayToFile(endPath, outFile);
            appendByteArrayToFile(fileBytes, outFile);
            appendByteArrayToFile(endBytes, outFile);

            return hideOK;
        }
        //Функция получения байт файла
        private byte[] readFileAllBytes(string pathToRead)
        {
            return File.ReadAllBytes(pathToRead);
        }
        //Функция добавления байт в конец файла
        private void appendByteArrayToFile(byte[] fileBytes,string pathToAppend)
        {
            using (var stream = new FileStream(pathToAppend, FileMode.Append))
            {                
                stream.Write(fileBytes, 0, fileBytes.Length);
            }
        }
        //Функция которая прячет папку по заданному пути
        private bool hideFolder(string pathFolder, string pathCut = "")
        {
            bool hideOK = true;
            //Вычисляем hash пароля
            byte[] hashPass = CalculateHash(pass);
            //Обрезаем путь файла и шифруем его
            string pathCutted = pathFolder.Replace(pathCut, "");
            byte[] unicodeBytesOfPath = Encoding.Unicode.GetBytes(pathCutted);
            unicodeBytesOfPath = enc(unicodeBytesOfPath);

            //Добавляем метки и шифрованный путь
            appendByteArrayToFile(DirectoryStart, outFile);
            appendByteArrayToFile(hashPass, outFile);
            appendByteArrayToFile(unicodeBytesOfPath, outFile);
            appendByteArrayToFile(DirectoryEnd, outFile);
                        
            return hideOK;
        }
        //Функция поиска определённых байт в массиве
        //для поиска меток, по которым определяем наличие и местоположение файла
        private long inBytes(byte[] bytes,byte[] subBytes, long startFrom = 0)
        {
            //long founded = -1;
            long lastFoundedByte = 0;
            for(long pos=startFrom; pos<bytes.LongLength-subBytes.LongLength+1;pos++)
            {
                bool founded = true;
                for (long posFound = pos; posFound < pos+subBytes.LongLength; posFound++)
                    if (bytes[posFound] != subBytes[posFound-pos])
                    {
                        founded = false;
                        break;
                    }
                if (founded) return pos;
            }
            return -1;
        }

        //Распаковщик
        public void unhideFiles(string extractTo)
        {
            byte[] hashPass = CalculateHash(pass);                   
            passGood = true;
            ExtractingNow = true;
            extractedFiles = 0;
            ExtractedFolders = 0;

            if (extractTo.Length == 0) extractTo = Directory.GetCurrentDirectory();
            else if (extractTo[extractTo.Length - 1] == '\\') extractTo.Remove(extractTo.Length - 1);
            outDirectory = extractTo + outMainFolder;
            //Заносим файл в байтовый массив и находим первые вхождения спрятанного файла и папки
            byte[] fileBytes = readFileAllBytes(inpFile);
            long filePos = inBytes(fileBytes, startBytes);
            long directoryPos = inBytes(fileBytes, DirectoryStart);
            //Пока найден спрятанный файл, распаковываем его
            while(/*passGood &&*/ (filePos>-1 && filePos<fileBytes.LongLength))
            {
                long fileEnd = inBytes(fileBytes, endBytes, filePos);
                if(extractFile(fileBytes, filePos, fileEnd))
                { extractedFiles++; }
                filePos = inBytes(fileBytes, startBytes,filePos+1);
            }
            //Пока найдена спрятанная папка, распаковываем её
            while (/*passGood &&*/ (directoryPos>-1 && directoryPos<fileBytes.LongLength))
            {
                long directoryEnd = inBytes(fileBytes, DirectoryEnd, directoryPos);
                if (extractDirectory(fileBytes, directoryPos, directoryEnd))
                { ExtractedFolders++; }
                directoryPos = inBytes(fileBytes,DirectoryStart, directoryPos+1);
            }
            ExtractingNow = false;
        }
        //Функция распаковки папки в указанном участке байтового массива
        private bool extractDirectory(byte[] fileBytes, long posStart, long posEnd)
        {
            bool sExtr = true;
            int size = 16;
            byte[] passHash = new byte[size];
            //Берём hash пароля из файла
            for (int pos = 0; pos < size; pos++)
            {
                passHash[pos] = fileBytes[posStart + pos + DirectoryStart.Length];
            }
            //Проверяем hash введённого пароля в данный момент
            //с hash'ом пароля который находится в файле
            if (!passwordIsTrue(passHash))
            {
                //Если пароль hash'ы не совпадают, то оставляем сообщение для другого потока
                //что пароль неправильный. А функции выше сообщаем, что распаковка не удалась
                passGood = false;
                sExtr = false;
            }
            else
            {   //Если пароль правильный, то находим путь папки, расшифровываем путь и создаём папку
                posStart += size;
                posStart += DirectoryStart.Length;
                long sizePath = posEnd - posStart;
                byte[] path = new byte[sizePath];
                for (int pos = 0; pos < sizePath; pos++)
                {
                    path[pos] = fileBytes[posStart + pos];
                }
                path = enc(path);
                string strPath = Encoding.Unicode.GetString(path);
                string directory = Path.GetDirectoryName(strPath);
                string folderToCreate = outDirectory + "\\" + directory;
                if (!Directory.Exists(folderToCreate))
                    Directory.CreateDirectory(folderToCreate);
                //Console.WriteLine("Path folder: " + Encoding.Unicode.GetString(path));
            }
            return sExtr;
        }
        //Функция распаковки файла в указанном участке байтового массива
        private bool extractFile(byte[] fileBytes,long posStart,long posEnd)
        {
            bool sExtr = true;
            int size = 16;
            //Берём hash пароля из файла
            byte[] passHash = new byte[size];
            for(int pos = 0; pos < size; pos++)
            {
                passHash[pos] = fileBytes[posStart+pos+startBytes.Length];
            }
            //Проверяем hash введённого пароля в данный момент
            //с hash'ом пароля который находится в файле
            if (!passwordIsTrue(passHash))
            {
                //Если пароль hash'ы не совпадают, то оставляем сообщение для другого потока
                //что пароль неправильный. А функции выше сообщаем, что распаковка не удалась
                passGood = false;
                sExtr = false;
            }
            else
            {   //Если пароль правильный, то находим путь файла, байты самого файла, расшифровываем всё это
                // создаём папку в которой находился файл и распаковываем байты в новый файл
                posStart += size;
                long posPathStart = inBytes(fileBytes, startPath, posStart)+startPath.Length;
                long posPathEnd = inBytes(fileBytes, endPath, posPathStart);
                long sizePath = posPathEnd - posPathStart;
                byte[] path = new byte[sizePath];
                for(int pos = 0; pos<sizePath;pos++)
                {
                    path[pos] = fileBytes[posPathStart + pos];
                }
                path = enc(path);
                string strPath = Encoding.Unicode.GetString(path);
                //Console.WriteLine("Decrypted Path: " + Encoding.Unicode.GetString(path));
                long fileStart = posPathEnd + endPath.Length;
                long fileEnd = inBytes(fileBytes, endBytes, fileStart);
                long fileSize = fileEnd - fileStart;
                byte[] hidedFile = new byte[fileSize];
                for (int pos = 0; pos < fileSize; pos++)
                {
                    hidedFile[pos] = fileBytes[fileStart + pos];
                }
                hidedFile = enc(hidedFile);
                string directory = Path.GetDirectoryName(strPath);                
                string folderToCreate = outDirectory + "\\" + directory;
                if (!Directory.Exists(folderToCreate))
                    Directory.CreateDirectory(folderToCreate);
                using (var hf = new FileStream(outDirectory+"\\"+strPath, FileMode.Create, FileAccess.Write))
                {
                    hf.Write(hidedFile, 0, hidedFile.Length);                    
                }
                //Console.WriteLine(outDirectory); 
            }
            return sExtr;
        }

        private int hidedFiles = 0;
        private int hidedFolders = 0;
        //Вычисляем количество спрятанных файлов и папок
        private void findCountHidedFiles()
        {
            hidedFiles = 0;
            byte[] fileBytes = File.ReadAllBytes(inpFile);
            int pos = 0;
            for (long i = 0; i < fileBytes.LongLength; i++)
            {
                if (fileBytes[i] == startBytes[pos])
                {
                    pos++;
                    if (pos == startBytes.Length)
                    {
                        hidedFiles++;
                        pos = 0;
                    }
                }
                else pos = 0;
            }

            pos = 0;
            for (long i = 0; i < fileBytes.LongLength; i++)
            {
                if (fileBytes[i] == DirectoryStart[pos])
                {
                    pos++;
                    if (pos == DirectoryStart.Length)
                    {
                        hidedFolders++;
                        pos = 0;
                    }
                }
                else pos = 0;
            }
        }

        public int getCountHidedFiles()
        {
            return hidedFiles;
        }

        public int getCountHidedFolders()
        {
            return hidedFolders;
        }

        public int getExtractedFiles()
        {
            return extractedFiles;
        }

        private int ExtractedFolders = 0;
        public int getExtractedFolders()
        {
            return ExtractedFolders;
        }
        //Создания потоков, для распаковки
        public void unhideFilesAtNewThread(string extractTo)
        {
            //Поток который вычисляет количество спрятанных файлов
            Thread threadDoCount = new Thread(findCountHidedFiles);
            threadDoCount.IsBackground = true;
            //Поток распаковщика
            Thread threadUnhideFiles = new Thread(() => unhideFiles(extractTo));
            threadUnhideFiles.IsBackground = true;

            threadUnhideFiles.Start();
            System.Threading.Thread.Sleep(50);
            threadDoCount.Start();
        }
        //Получения прогресса распаковщика в процентах
        public int getExtractingProgress()
        {
            int progress = 0;
            if (hidedFiles != 0)
                progress = (int)(((float)extractedFiles / hidedFiles) * 100);
            if (progress == 100 && ExtractingNow)
                progress = 99;
            return progress;
        }

        public bool ExtractingStatus()
        {
            return ExtractingNow;
        }

        private int extractedFiles = 0;
        private bool ExtractingNow = false;
        private string outDirectory = "";

        public string getOutDirectory()
        {
            return outDirectory;
        }
        //Поиск байтов в файле
        /*private long findPos(byte[] fileBytes, byte[] findBytes, bool firstOccurrence = true, long fromPos=0)
        {
            long foundedPos = -1;
            long pos = 0;
            long i;
            if (fromPos>=0)
                for (i = fromPos; i < fileBytes.LongLength; i++)
                {
                    if (fileBytes[i] == findBytes[pos])
                    {
                        pos++;
                        if (pos == findBytes.LongLength)
                        {
                            if (firstOccurrence)
                            { foundedPos = i - findBytes.Length + 1; }
                            else { foundedPos = i + 1; }
                            pos = 0;
                            break;
                        }
                    }
                    else pos = 0;
                }
            return foundedPos;
        }*/

    }
}
