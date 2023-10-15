namespace EugeneAnykey.Project.BlockLines.Types
{
    internal class ChangesCounter
    {
        #region fields
        public int Additions { get; private set; } = 0;
        public int Removes { get; private set; } = 0;
        public int Updates { get; private set; } = 0;
        public bool GotChanges
        {
            get { return Additions > 0 && Removes > 0 && Updates > 0; }
        }

        public string Info
        {
            get { return $"Additions: {Additions}\nRemoves: {Removes}\nUpdates: {Updates}"; }
        }
        #endregion


        #region init
        public ChangesCounter() { }
        #endregion


        #region public
        public void Reset()
        {
            Additions = 0;
            Removes = 0;
            Updates = 0;
        }

        public void IncAdditions() => Additions++;

        public void IncRemoves() => Removes++;

        public void IncUpdates() => Updates++;
        #endregion
    }
}
