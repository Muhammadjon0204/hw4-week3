using System;

namespace hw2;

public class PhotoBook
{

private int _numPages;

public PhotoBook()
    {
        _numPages=16;
    }
public PhotoBook(int num)
    {
        _numPages=num;
    }    

public int GetNumPages()
    {
        return _numPages;
    }

}
