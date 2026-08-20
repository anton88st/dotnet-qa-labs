namespace RockPaperScissors.GameObjects
{
    internal abstract class GameObject
    {
        public string ObjectName { get; }
        public int ObjectId { get; }

        protected GameObject(string objectName, int objectId)
        {
            ObjectName = objectName;
            ObjectId = objectId;
        }

        public string CompareText(GameObject other) => GameRules.CompareText[ObjectId, other.ObjectId];

        public int Compare(GameObject other) => GameRules.Comparison[ObjectId, other.ObjectId];

        public override string ToString() => ObjectName;
    }
}
