﻿namespace UContactStats.Exceptions;

public class NullOrEmptySPException : Exception
{
    public NullOrEmptySPException() : base("No se ha indicado ningún Store Procedure.")
    {

    }
}
