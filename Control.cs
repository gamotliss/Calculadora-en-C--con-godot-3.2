using Godot;
using System;

public class Control : Godot.Control
{
	
	
	double a;
	double b; 
	string c;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
		
		
}

public void _on_n1_pressed()
{
	
  Label player = (Label)GetNode("pantalla");
  if (player.Text == "")
	{
		player.Text = "1";
	}
	
	else
		{
		player.Text = player.Text + "1" ;
		}
  

}


	private void _on_n2_pressed()
	{	
	Label player = (Label)GetNode("pantalla");
  	if (player.Text == "")
		{
			player.Text = "2";
		}
			
		else
		{
		player.Text = player.Text + "2" ;
		}
		
	}
	
	
	private void _on_n3_pressed()
	{
		Label player = (Label)GetNode("pantalla");
	  	if (player.Text == "")
		{
			player.Text = "2";
		}
			
		else
		{
		player.Text = player.Text + "2" ;
		}
	}
	
	
	
	
}	

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
	
