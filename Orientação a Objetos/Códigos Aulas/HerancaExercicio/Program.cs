using HerancaExercicio;

ContaCorrente cc = new("João", 1);
ContaPoupanca cp = new("Maria", 2);
ContaInvestimento ci = new("José", 3);

cc.Depositar(1000.0m);
cp.Depositar(1000.0m);
ci.Depositar(1000.0m);

cc.ExibirSaldo();
cp.ExibirSaldo();
ci.ExibirSaldo();

cc.Sacar(100.0m);
cp.Sacar(100.0m);
ci.Sacar(100.0m);

cc.ExibirSaldo();
cp.ExibirSaldo();
ci.ExibirSaldo();

cc.Sacar(2000.0m);
cp.Sacar(2000.0m);
ci.Sacar(2000.0m);

cc.ExibirSaldo();
cp.ExibirSaldo();
ci.ExibirSaldo();
