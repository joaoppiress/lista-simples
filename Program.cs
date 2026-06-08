Lista listaSE = new(); //Nesse momento a lista está vazia

listaSE.inserirInicio(10);
listaSE.inserirInicio(20);
listaSE.inserirInicio(51);

listaSE.removerInicio();

Console.WriteLine("\nApós remover início:");
listaSE.percurso();

listaSE.removerFim();

Console.WriteLine("\nApós remover fim:");
listaSE.percurso();