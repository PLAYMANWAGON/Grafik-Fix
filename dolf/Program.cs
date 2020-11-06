using System;
using Raylib_cs;


namespace Grafik
{
    class Program
    {
        static void Main(string[] args)
        {

            Raylib.InitWindow(800, 600, "test");
            Console.WriteLine("Hello World!");

            Random generator = new Random();

            string scene = "convo";

            int textOrder = 0;

            int height = 600;

            int width = 800;

            int x = 350;

            int y = 250;

            int mX = Raylib.GetMouseX();

            int mY = Raylib.GetMouseY();

            int sqSize = 50;

            int squareX = generator.Next(50, 700);

            int squareY = generator.Next(50, 500);

            Color transparent = new Color(0, 0, 0, 0);

            Rectangle enemyRect = new Rectangle(squareX, squareY, sqSize, sqSize);

            /* IMPORTED TEXTURES AND IMAGES AND WHATNOT */

            Image keefImg = Raylib.LoadImage(@"keef.png");

            Texture2D keefTex = Raylib.LoadTextureFromImage(keefImg);

            Image uffeImg = Raylib.LoadImage(@"uffe.png");

            Texture2D uffeTex = Raylib.LoadTextureFromImage(uffeImg);

            Image gladImg = Raylib.LoadImage(@"gladuffe.png");

            Texture2D gladTex = Raylib.LoadTextureFromImage(gladImg);



            while (!Raylib.WindowShouldClose())
            {



                if (scene == "game")
                {

                    Rectangle playerRect = new Rectangle(x, y, sqSize, sqSize);

                    if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT) && x < width - sqSize)
                    {

                        x++;

                    }

                    if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT) && x > 0)
                    {

                        x--;

                    }

                    if (Raylib.IsKeyDown(KeyboardKey.KEY_UP) && y > 0)
                    {

                        y--;

                    }

                    if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN) && y < height - sqSize)
                    {

                        y++;

                    }

                    if (Raylib.CheckCollisionRecs(playerRect, enemyRect))
                    {

                        scene = "interlude";
                    }






                    Raylib.BeginDrawing();

                    Raylib.ClearBackground(Color.WHITE);

                    Raylib.DrawRectangleRec(playerRect, Color.MAGENTA);

                    Raylib.DrawRectangleRec(enemyRect, Color.GREEN);


                    Raylib.EndDrawing();

                }

                if (scene == "interlude")
                {


                    if (Raylib.IsKeyDown(KeyboardKey.KEY_SPACE))
                    {

                        scene = "convo";
                    }

                    Raylib.BeginDrawing();

                    Raylib.ClearBackground(Color.MAROON);

                    Raylib.DrawText("Nice!", width / 2 - 64, height / 5, 64, Color.WHITE);

                    Raylib.EndDrawing();


                }

                if (scene == "convo")
                {


                    if (Raylib.IsKeyPressed(KeyboardKey.KEY_Z))
                    {

                        textOrder++;
                    }

                    if (Raylib.IsKeyPressed(KeyboardKey.KEY_X))
                    {

                        textOrder--;
                    }



                    Raylib.BeginDrawing();

                    Raylib.ClearBackground(Color.BLACK);

                    Raylib.DrawRectangle(200, 350, 400, 200, Color.BROWN);

                    Raylib.DrawRectangle(210, 360, 380, 180, Color.BEIGE);

                    Raylib.DrawText("Press \"Z\" to continue. \"X\" to go back", 213, 530, 6, Color.WHITE);

                    if (textOrder == 0)
                    {

                        Raylib.DrawText("Hello, this is a textbox.", 220, 370, 18, Color.BLACK);

                    }

                    if (textOrder == 1)
                    {

                        Raylib.DrawText("Fun fact, this textbox is horribly \nprogrammed.", 220, 370, 18, Color.BLACK);

                    }

                    if (textOrder == 2)
                    {

                        Raylib.DrawText("Each piece of text, like this one, is \ndisplayed using a score counter and an \nif statement.", 220, 370, 18, Color.BLACK);

                    }

                    if (textOrder == 3)
                    {

                        Raylib.DrawText("It probably could be made better, but I'm \ntoo lazy to read how Raylib works.", 220, 370, 18, Color.BLACK);

                    }

                    if (textOrder == 4)
                    {

                        Raylib.DrawTexture(keefTex, 0, 200, Color.WHITE);

                        Raylib.DrawRectangle(200, 350, 400, 200, Color.BROWN);

                        Raylib.DrawRectangle(210, 360, 380, 180, Color.BEIGE);

                        Raylib.DrawText("If im a master programmer, a dude should\npopup here as if he's talking.", 220, 370, 18, Color.BLACK);

                    }

                    if (textOrder == 5)
                    {

                        Raylib.DrawTexture(keefTex, 0, 200, Color.WHITE);

                        Raylib.DrawRectangle(200, 350, 400, 200, Color.BROWN);

                        Raylib.DrawRectangle(210, 360, 380, 180, Color.BEIGE);

                        Raylib.DrawText("\"Bitches love sosa.\"", 220, 370, 18, Color.BLACK);

                    }

                    if (textOrder == 6)
                    {

                        Raylib.DrawText("Wow that was awesome.", 220, 370, 18, Color.BLACK);

                    }

                    if (textOrder == 7)
                    {

                        Raylib.DrawTexture(uffeTex, 600, 200, Color.WHITE);

                        Raylib.DrawRectangle(200, 350, 400, 200, Color.BROWN);

                        Raylib.DrawRectangle(210, 360, 380, 180, Color.BEIGE);

                        Raylib.DrawText("\"Hello I am the real Ulf Beck.\"", 220, 370, 18, Color.BLACK);

                    }

                    if (textOrder == 8)
                    {

                        Raylib.DrawText("Holy crap is that the real Ulf Beck?", 220, 370, 18, Color.BLACK);

                    }

                    if (textOrder == 9)
                    {

                        Raylib.DrawTexture(gladTex, 600, 200, Color.WHITE);

                        Raylib.DrawRectangle(200, 350, 400, 200, Color.BROWN);

                        Raylib.DrawRectangle(210, 360, 380, 180, Color.BEIGE);

                        Raylib.DrawText("\"Yes.\"", 220, 370, 18, Color.BLACK);

                    }



                    Raylib.EndDrawing();

                }





            }
        }
    }
}
