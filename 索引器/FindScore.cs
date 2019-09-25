using System;
using System.Collections.Generic;
using System.Text;

namespace 索引器
{
    public class FindScore
    {
        private List<Scores> listScores;
        public FindScore()
        {
            listScores = new List<Scores>();
            
        }
        //索引器 通过名字&课程编号查找和保存成绩
        public int this[string stuName, int courseId]
        {
            get
            {
                Scores s = listScores.Find(x => x.StuName == stuName && x.CourseId == courseId);
                if(s != null)
                {
                    return s.Score;
                }
                else
                {
                    return -1;
                }
            }
            set
            {
                listScores.Add(new Scores { StuName = stuName, CourseId = courseId, Score = value });
            }
        }
        //索引器重载,根据名字查找所有成绩
        public List<Scores> this[string stuName]
        {
            get
            {
                List<Scores> tempList = listScores.FindAll(x => x.StuName == stuName);
                return tempList;
            }
        }
            
    }
}
