﻿namespace CSClass
{
    class Student
    {
        /// <summary>
        /// 학생 이름
        /// </summary>
        public string name;
        /// <summary>
        /// 학생 성적
        /// </summary>
        public int grade;

        /// <summary>
        /// 학생 객체 문자열 출력 메소드
        /// </summary>
        /// <returns>학생 이름 : 학생 성적 문자열 리턴</returns>
        public override string ToString()
        {
            return this.name + " : " + this.grade;
        }
    }
}