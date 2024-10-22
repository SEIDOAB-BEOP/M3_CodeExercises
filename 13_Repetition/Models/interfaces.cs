    namespace Models;
    
    public enum enMemberLevel { Platinum, Gold, Silver, Blue}
    public interface IMember: IEquatable<IMember>, IComparable<IMember>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public enMemberLevel Level {get; set;}
        public DateTime Since { get; set; }
    }

    public interface IMemberList
    {
        public string HotelName { get; set; }
        public IMember this[int idx] { get; }  
        
        int Count();
        int Count(int year);
        IMemberList Sort();
        IMemberList AddFirst(IMember member);
        IMemberList AddLast(IMember member);
        IMemberList RemoveFirst();
        IMemberList RemoveLast();}