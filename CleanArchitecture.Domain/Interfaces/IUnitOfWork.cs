using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Domain.Interfaces;

public interface IUnitOfWork
{
    Task Commit(CancellationToken cancellationToken);
}
