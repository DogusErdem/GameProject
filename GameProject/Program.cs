using GameProject.Entities;
using GameProject.Absrtact;
using GameProject.Concerte;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GameManager gameManager = new GamerManager(new GamerCheck()) ;
            
            
        }
    }
}
