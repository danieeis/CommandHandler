using System;

public class CreateBookHandler : ICommandHandler<Book>{
    public void Handle(Book entity){
        Console.WriteLine(
            $"{entity.BookName} should be added to authors"
        );
    }
}
public class DeleteBookHandler : ICommandHandler<Book>{
    public void Handle(Book entity){
        Console.WriteLine(
            $"{entity.BookName} should be delete to authors"
        );
    }
}