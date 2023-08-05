

namespace HW1841 {
    class Send {
        Command _comanda;

        public void SetCommand(Command _command) {
            _comanda = _command;
        }
        public void Run() {
            _comanda.Run();
        }
    }
}