using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_1
{
    class CoursesData
    {
        public List<CourseData> courses { get; set; }
    }

    class CourseData
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    class KuliahMahasiswa
    {
        public static void ReadJSON()
        {
            Console.WriteLine("\nDaftar Mata Kuliah yang diambil:");

            string jsonCourses = File.ReadAllText("C:\\Users\\LENOVO\\tpmodul7_kelompok_1\\tp7_2_103022390001.json");
            CoursesData courses = JsonSerializer.Deserialize<CoursesData>(jsonCourses);

            foreach (CourseData course in courses.courses)
            {
                Console.WriteLine($"MK 1 {course.code} - {course.name}");
            }
        }
    }
}