using System.Linq;
using System.Collections.Generic;
using System;

public class Solution
{
    private struct GenreInfo
    {
        public int index;
        public int play;

        public GenreInfo(int index, int play) { this.index = index; this.play = play; }
    }

    private struct GenreData
    {
        public List<GenreInfo> infos;

        public int TotalPlay
        {
            get
            {
                int _return = 0;
                foreach (GenreInfo info in infos) _return += info.play;
                return _return;
            }
        }

        public GenreData(List<GenreInfo> infos) { this.infos = infos; }
    }



    public int[] solution(string[] genres, int[] plays)
    {
        Dictionary<string, GenreData> genreDict = new Dictionary<string, GenreData>();
        for (int i = 0; i < genres.Length; i++)
        {
            if (genreDict.ContainsKey(genres[i])) genreDict[genres[i]].infos.Add(new GenreInfo(i, plays[i]));
            else genreDict.Add(genres[i], new GenreData(new List<GenreInfo>() { new GenreInfo(i, plays[i]) }));
        }

        var desc_genreDict = genreDict.OrderByDescending(a => a.Value.TotalPlay);

        List<int> answer = new List<int>();
        foreach (var genre in desc_genreDict)
        {
            genre.Value.infos.Sort((a, b) => b.play.CompareTo(a.play));

            for (int i = 0; i < Math.Min(2, genre.Value.infos.Count); i++)
            {
                answer.Add(genre.Value.infos[i].index);
            }
        }

        return answer.ToArray();
    }
}