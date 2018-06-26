using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horsesoft.Wpf.Controls.Audio.internals
{
    public enum CamelotMinorKey
    {
        None = 0,
        Abm = 1 << 0,    //1A
        Ebm = 1 << 1,    //2A
        Bbm = 1 << 2,
        Fm = 1 << 3,
        Cm = 1 << 4,
        Gm = 1 << 5,
        Dm = 1 << 6,
        Am = 1 << 7,
        Em = 1 << 8,
        Bm = 1 << 9,
        Gbm = 1 << 10,
        Dbm = 1 << 11
    }

    public enum CamelotMajorKey
    {
        B = 1 << 12,    //1B
        Gb = 1 << 13,    //2B
        Db = 1 << 14,
        Ab = 1 << 15,
        Eb = 1 << 16,
        Bb = 1 << 17,
        F = 1 << 18,
        C = 1 << 19,
        G = 1 << 20,
        D = 1 << 21,
        A = 1 << 22,
        E = 1 << 23
    }

    [Flags]
    public enum OpenKeyNotation
    {
        None = 0,
        Am = CamelotMinorKey.Am,     //1m
        Em = CamelotMinorKey.Em,     //2m
        Bm = CamelotMinorKey.Bm,     //3m
        Gbm = CamelotMinorKey.Gbm,
        Dbm = CamelotMinorKey.Dbm,
        Abm = CamelotMinorKey.Abm,
        Ebm = CamelotMinorKey.Ebm,
        Bbm = CamelotMinorKey.Bbm,
        Fm = CamelotMinorKey.Fm,
        Cm = CamelotMinorKey.Cm,
        Gm = CamelotMinorKey.Gm,
        Dm = CamelotMinorKey.Dm,
        //Inner row - Major
        C = CamelotMajorKey.C,     //1d
        G = CamelotMajorKey.G,     //2d
        D = CamelotMajorKey.D,     //3d
        A = CamelotMajorKey.A,
        E = CamelotMajorKey.E,
        B = CamelotMajorKey.B,
        Gb = CamelotMajorKey.Gb,
        Db = CamelotMajorKey.Db,
        Ab = CamelotMajorKey.Ab,
        Eb = CamelotMajorKey.Eb,
        Bb = CamelotMajorKey.Bb,
        F = CamelotMajorKey.F
    }
}
