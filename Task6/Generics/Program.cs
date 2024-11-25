//Hyeonsu KIM  A24586

using Generics_Library;

Library<Book> bookLibrary = new Library<Book>();
Library<Newspaper> newspaperLibrary = new Library<Newspaper>();
Library<Video> videoLibrary = new Library<Video>();

//store the information of the media
bookLibrary.add_media(new Book("The Hobbit", "Houghton Mifflin Harcourt", "J.R.R. Tolkien", 310));
bookLibrary.add_media(new Book("The Fellowship of the Ring", "Houghton Mifflin Harcourt", "J.R.R. Tolkien", 398));
bookLibrary.add_media(new Book("The Two Towers", "Houghton Mifflin Harcourt", "J.R.R. Tolkien", 327));

newspaperLibrary.add_media(new Newspaper("The New York Times", "The New York Times Company", "2021-10-01", "Breaking News"));
newspaperLibrary.add_media(new Newspaper("The Washington Post", "Nash Holdings", "2021-10-01", "Breaking News"));
newspaperLibrary.add_media(new Newspaper("The Wall Street Journal", "Dow Jones & Company", "2021-10-01", "Breaking News"));

videoLibrary.add_media(new Video("The Shawshank Redemption", "Columbia Pictures", "Frank Darabont", "2h 22m"));
videoLibrary.add_media(new Video("The Godfather", "Paramount Pictures", "Francis Ford Coppola", "2h 58m"));
videoLibrary.add_media(new Video("The Dark Knight", "Warner Bros. Pictures", "Christopher Nolan", "2h 32m"));


//retrieve and display the information of the media
bookLibrary.search_media("The Hobbit"); //suceess
newspaperLibrary.search_media("The New York Times"); //suceess
videoLibrary.search_media("The Shawshank Redemptio"); //fail
