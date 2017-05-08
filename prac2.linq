<Query Kind="Statements">
  <Connection>
    <ID>f76aaa38-ba33-44e0-94fb-acf2abcc8e58</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from a in Artists
			  where a.ArtistId == 1
			  orderby a.Name
			  select new 
			  {
			    Artist = a.Name,
				Albums = from b in a.Albums
						 orderby b.Title
						 select new
						{
						 Title = b.Title,
						 Year = b.ReleaseYear,
						 Label = b.ReleaseLabel
						}
			  };
results.Dump();