<Query Kind="Statements">
  <Connection>
    <ID>f76aaa38-ba33-44e0-94fb-acf2abcc8e58</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from x in Artists
			  orderby x.Name descending
			  select new
			  {
				ID = x.ArtistId,
				Name = x.Name
			  };
results.Dump();