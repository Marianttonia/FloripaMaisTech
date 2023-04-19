int [] buscadorNumerosPrimos = new int[10]; // declarei o array numérico e seu espaço de memória com 10 índices.
// Agora vou criar laço que repetirá para exibir 10 vezes em tela os valores inseridos pelo usuário:

for (int i=0, i<10; i ++) { 
    // $ mostrará que irá chamar variáveis através das chaves {}, exibe pedido dos valores do usuário 10x.
    Console.WriteLine ($"Digite o {i + 1}° número: ");
    // {i+1}° faz referência ao laço integrador que irá aumentar (mesmo que ++)
    // Agora vamos receber esses dados do usuário convertendo-os em números:
    int numeros = Int32.Parse(Console.ReadLine());
    // int numeros é nova variável para esses dados recebidos.
    // int32Parse é para trazer inteiros até 3 bits.
    buscadorNumerosPrimos[i] = numeros;
    // O valor digitado pelo usuário será direcionado dentro do laço.
}

// Laço feito, recebendo os 10 valores do usuário, agora vamos tratá-los, separando-os em primos e exibindo em ordem crescente.

for (int i=1; i<10, i++) {
    int contador = 1;
    // Conferindo divisores de 1 a 10 no laço, começa em 1 pois 0 quebraria. Esses valores serão armazenados.
    for (int n=1; n<buscadorNumerosPrimos[i]; n++) {
        // n é o divisor, por isso começa com 1.
        // nesse código confere os divisores inteiros digitados pelo usuário.
        if (buscadorNumerosPrimos[i]% n==0) {
        contador=contador+1; //contador ++.
        }
    } // Se o contador der 2 ele é primo, pois 1+1 é 2.
    // Considerando que o módulo% (resto) da divisão seja 0 apenas dividindo por 1, já que o divisor (n) será menor que o inteiro inserido.
    if (contador==2) {
        Console.WriteLine($"O número {buscadorNumerosPrimos[i]} é um número primo e ele está na posição {i} do array de números. ")
    }  
}