Console.WriteLine("Hello");

/*
255, 255, 255-- > "FFFFFF"
255, 255, 300-- > "FFFFFF"
0, 0, 0-- > "000000"
148, 0, 211-- > "9400D3"
*/
string Input(int r, int g =0, int b = 0)
{

    if (r == 0 || r < 0)
        r = 00;
    if (g == 0 || g < 0)
        g = 00;
    if (b == 0 || b < 0)
        b = 00;
    if(r > 255)
        r = 255;
    if (g > 255)
        g = 255;
    if (b > 255)
        b = 255;
    int hexValueMainR = r / 16;
    int hexValueOstR = r % 16;
    int hexValueMainG = g / 16;
    int hexValueOstG= g % 16;
    int hexValueMainB = b / 16;
    int hexValueOstB = b % 16;
    return hexValueMainR.ToString() + hexValueOstR.ToString() + hexValueMainG.ToString() + hexValueOstG.ToString() + hexValueMainB.ToString() + hexValueOstB.ToString();
}

int r = 32;
int g = -1;
int b = 256;
string a = Input(r,g,b);
Console.WriteLine(a);