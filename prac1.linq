<Query Kind="Statements">
  <Connection>
    <ID>f76aaa38-ba33-44e0-94fb-acf2abcc8e58</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from x in Artists
			  where x.ArtistId == 1
			  orderby x.Name
			  select new 
			  {
				Artist = x.Name,
				Albums = from t in Albums
						 orderby t.Title
						 select new
						 {
							Title = t.Title,
							Tracks = from tr in t.Tracks
									select new
									{
										TrackName = tr.Name,
										Genre = tr.Genre.Name,
										Composer = tr.Composer,
										Milliseconds = tr.Milliseconds
									}
						 }
			  };
results.Dump();