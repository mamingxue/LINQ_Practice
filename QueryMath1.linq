<Query Kind="Statements">
  <Connection>
    <ID>14367277-cee1-4991-b861-fc392ab3e0d8</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from g in Genres
			  orderby g.Name
			  select new
			  {
			    Genre = g.Name,
				
				TracksCount = g.Tracks.Count()
			  };
results.Dump("Query Math 1");