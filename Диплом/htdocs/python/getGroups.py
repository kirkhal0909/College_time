
import mysql.connector

mydb = mysql.connector.connect(
  host="localhost",
  user="root",
  passwd="",
  database="db_students"
)

mycursor = mydb.cursor()

sql_grp = "INSERT INTO groups_now(group_id, group_by_number, group_start_year, group_end_year) VALUES (%s, %s, %s, %s)"
sql_student = "INSERT INTO students(group_unique_group_id,student_second_name, student_name, student_middle_name, student_gender) VALUES (%s, %s, %s, %s, %s)"




f = open('students.txt','r')
t = f.read().split('\n')
f.close()

grp_id = {'ПКС':'1',
          'КСК':'2',
          'Д':'3',
          'Т':'4',
          'ПП':'5',
          'АК':'6',
          'ОДЛ':'7',
          'Ф':'8',
          'ИД':'9',}

grp_end = {'ПКС':4,
          'КСК':4,
          'Д':4,
          'Т':4,
          'ПП':4,
          'АК':4,
          'ОДЛ':3,
          'Ф':3,
          'ИД':4,}

grps = []
grp = []
std_all = 0
for line in t:
    tmp = line
    line = line.split(' ')
    if len(line)==1:
        line = line[0]
        lineCourse = line[0]
        groupNum = ''
        group = ''
        for s in range(1,len(line)):
            s = line[s]
            if s>='0' and s<='9':
                groupNum = groupNum+s
            else:
                group = group+s

        start_year = 2019-int(lineCourse)
        g_id = grp_id[group]
        end_year = start_year+grp_end[group]        
        grps.append([str(start_year),str(end_year),g_id,groupNum,[]])

        val = (g_id, groupNum,str(start_year),str(end_year))
        mycursor.execute(sql_grp, val)
        
        mydb.commit()
        
        grp_now_id = mycursor.getlastrowid()
        #grp = grps[-1]
    else:
        std_all+=1        
        mid = ''
        for i in range(2,len(line)-1):
            mid = mid+line[i]+' '
        mid = mid[0:-1]
        gender = '1'
        if line[-1]=='girl':
            gender = '2'
        val = (str(grp_now_id),line[0],line[1],mid,gender)
        mycursor.execute(sql_student, val)
        
        mydb.commit()
        print(std_all)
    grps[-1][4].append(line)
    
print(grps)
        
