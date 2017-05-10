<Query Kind="Statements">
  <Connection>
    <ID>14367277-cee1-4991-b861-fc392ab3e0d8</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from g in Genres
			  where g.Name.Equals("Heavy Metal")
			  select new
			  {
				TracksCount = g.Tracks.Count(),
				Tracks = from t in g.Tracks
						 select new
						{
							TrackName = t.Name,
							AlbumName = t.Album.Title,
							Milliseconds = t.Milliseconds,
							Size = (t.Bytes / 1000) + "kb",
							Price = t.UnitPrice
						}
			  };
results.Dump("Query Math 1");