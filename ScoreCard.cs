using CsvHelper.Configuration;

namespace _2020_draft_scorer
{

    public class ScoreCard
    {
        public int Ross;
        public int Jawad;
        public int Tilo;
        public int Jared;
        public int AJ;

        public ScoreCard () {}
        public ScoreCard (int ross, int jawad, int tilo, int jared, int aj)
        {
            this.Ross = ross;
            this.Jawad = jawad;
            this.Tilo = tilo;
            this.Jared = jared;
            this.AJ = aj;
        }
    }
    public sealed class ScoreCardCsvMap : ClassMap<ScoreCard>
    {
        public ScoreCardCsvMap()
        {
            Map(m => m.Ross).Name("Ross");
            Map(m => m.Jawad).Name("Jawad");
            Map(m => m.Tilo).Name("Tilo");
            Map(m => m.Jared).Name("Jared");
            Map(m => m.AJ).Name("AJ");
        }
    }
}