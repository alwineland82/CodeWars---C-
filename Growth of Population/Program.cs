int NbYear(int p0, double percent, int aug, int p) {
        int count = 0;
        while(p0 < p)
          {
          p0 = (int)(p0 + p0 * (percent / 100) + aug);
          count += 1;
        }
      return count;
    }


Console.WriteLine(NbYear(1500, 5, 100, 5000));

using System;

class Arge {
    
    public static int NbYear(int p0, double percent, int aug, int p) {
        int year;
        for (year = 0; p0 < p; year++)
          p0 += (int)(p0*percent/100) + aug;
        return year;
    }
}