﻿using System;
using System.Collections.Generic;
using System.Text;

namespace bank
{
    class Menu
    {
        Application appMenu = new Application();
        private int MenuSelect;
        private string[] Options;
        private string Prompt;

        public Menu(string prompt, string[] options)
        {
            this.Prompt = prompt;
            this.Options = options;
            this.MenuSelect = 0;
        }

        private void DisplayOptions()
        {
            appMenu.Logo();
            Console.WriteLine(Prompt);
            for (int i = 0; i < Options.Length; i++)
            {
                string MenuOptions = Options[i];

                if (i == MenuSelect)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }

                Console.WriteLine($" << {MenuOptions} >> ");
            }
            Console.ResetColor();
        }

        public int Run()
        {
            ConsoleKey keyPressed;
            do
            {
                Console.Clear();
                DisplayOptions();

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                keyPressed = keyInfo.Key;

                // Update SelectedIndex based on arrow keys.
                if (keyPressed == ConsoleKey.UpArrow)
                {
                    MenuSelect--;
                    if (MenuSelect == -1)
                    {
                        MenuSelect = Options.Length - 1;
                    }
                }
                else if (keyPressed == ConsoleKey.DownArrow)
                {
                    MenuSelect++;
                    if (MenuSelect == Options.Length)
                    {
                        MenuSelect = 0;
                    }
                }
            } while (keyPressed != ConsoleKey.Enter);

            return MenuSelect;
        }
    }
}