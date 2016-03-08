using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Friends
{
    class FriendsCollection
    {
        int friendsCount = 0;
        List<Friend> friends = new List<Friend>();

        public void Add(params Friend[] newFriends)
        {
            if(friendsCount == 100)
            {
                throw new ArgumentOutOfRangeException("Too many friends!");
            }
            foreach (Friend newFriend in newFriends)
            {
                friends.Add(newFriend);
                friendsCount = friends.Count;
            }
        }

        public Friend[] GetAll()
        {
            var result = new Friend[friendsCount];
            for (int i = 0; i < friendsCount; i++)
            {
                result[i] = friends[i];
            }
            return result;
        }

        public Friend this[int index]
        {
            get
            {
                return friends[index];
            }
            set
            {
                friends.Insert(index, value);
            }
        }

        public Friend this[string Name]
        {
            get
            {
                return friends[GetIndexFromName(Name)];
            }
            set
            {
                friends.Insert(GetIndexFromName(Name), value);
            }
        }

        private int GetIndexFromName(string Name)
        {
            return friends.FindIndex(0, item => item.Name == Name);
        }
    }
}
