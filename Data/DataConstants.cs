namespace oldCapitalWeb.Data
{
    public static class DataConstants
    {
        public static class ArticleConstatns
        {
            public const int TitleMaxLength = 200; //min 25

            public const int TextMaxLength = 1000; //min 100
        }

        public static class ArtistConstatns
        {
            public const int NameMaxLength = 200; //min 3

            public const int DescriptionMaxLength = 1000;
        }

        public static class MessageConstatns
        {
            public const int NameMaxLength = 200; //min 3

            public const int EmailMaxLength = 125; //min 50

            public const int PhoneMaxLength = 10; //min 8

            public const int SubjectMaxLength = 200; //min 10

            public const int TextMaxLEngth = 1000; //min 100
        }

        public static class ContactUsConstatns
        {
            public const int AddressMaxLength = 125; //min 55

            public const int EmailMaxLength = 125; //min 50

            public const int PhoneMaxLength = 10; //min 8

            public const int MapLinkMaxLength = 700;
        }

        public static class FaQConstatns
        {
            public const int QuestionMaxLength = 255;

            public const int AnswerMaxLength = 255;
        }
    }
}
