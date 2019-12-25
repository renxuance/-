using CourseManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseManager.Migrations.Seeds
{
    public class SideBarCreator
    {
        private readonly CourseManager.Models.CourseManagerEntities _context;
        public SideBarCreator(CourseManager.Models.CourseManagerEntities context)
        {
            _context = context;
        }

        public SideBarCreator()
        {
            // TODO: Complete member initialization
        }
        public void Seed()
        {
            var initialSideBars = new List<SideBars>
           {
             new SideBars
               {
               Name="班级管理",
               Contorller="Class",
               Actio="Index"
             },
             new SideBars
               {
               Name="教师管理",
               Contorller="Teacher",
               Actio="Index"
             },
             new SideBars
               {
               Name="学生管理",
               Contorller="Student",
               Actio="Index"
             },
             new SideBars
               {
               Name="课程科目管理",
               Contorller="Course",
               Actio="Index"
             },
             new SideBars
               {
               Name="课程安排",
               Contorller="CourseManagement",
               Actio="Index"
             },
             new SideBars
               {
               Name="顶部导航栏管理",
               Contorller="ActionLink",
               Actio="Index"
             },
              new SideBars
               {
               Name="侧边栏管理",
               Contorller="SideBar",
               Actio="Index"
             },
           };
            foreach (var bar in initialSideBars)
            {
                if (_context.SideBars.Any(r => r.Name == bar.Name))
                {
                    continue;
                }
                _context.SideBars.Add(bar);
            }
            _context.SaveChanges();
        }
    }
}