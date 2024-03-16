namespace GU1_W07_ResizeableInterface
{
  public abstract class Shape : IResizeable
  {
    private string color = "green";
    private bool filled = true;

    public Shape()
    {
    }

    public Shape(string color, bool filled)
    {
      this.color = color;
      this.filled = filled;
    }
    public abstract void Resize(double percent);

    public string getColor()
    {
      return color;
    }

    public void setColor(string color)
    {
      this.color = color;
    }

    public bool isFilled()
    {
      return filled;
    }

    public void setFilled(bool filled)
    {
      this.filled = filled;
    }

    public override string ToString()
    {
      return "A Shape with color of "
              + getColor()
              + " and "
              + (isFilled() ? "filled" : "not filled");
    }
  }
}
