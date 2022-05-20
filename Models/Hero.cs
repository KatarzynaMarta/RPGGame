namespace RPGGame
{
    public class Hero : IPlayer

    {
        public int Health { get ; set ; }
        public int? RoundsWon { get ; set ; }
        public int Level { get ; set ; }
        public int Gold { get ; set ; }
        public int Damage { get ; set; }

        public Hero()
        {
            Health = 10;
            RoundsWon = 0;
            Gold = 0;
            Level = 0;
            Damage = 0;
        }


        public void Image()
        {//https://ascii.co.uk/art/knights
            Console.WriteLine($@"    
                            .oo.
                           .\.                                            ..
                         ,'..''\                                  ...oooo''
                         |  \_/'                          ...oooo'''
                         /''.'\               .   ...oooo'''
                        |  | '|           ...o!oo'''
                        |  |  |.  ...oooo''./    '\
                        |  '\, ''''\     ./    ./\ '\.
                      /\ooo''|''''-/ -../    / \''   '\.
                     /  '\.  '|.''\--/-+-+-+-+-+-+-+-+.'
               ....- \.    \.  '\-'/',,   /'---/' '''
            ././     ''\.-.-.\   '\|   '',,\--;
           /-/|             |-'\.  '>       '\\
          !--!|            /---/' ./'          |
          !--!!          ./---/' ,/|           |
        ./'-/'|          |----\  \-|           |
      ./'--/  |..........|''''''./'|...........|
     -'-'-'   '/---/\---|'          '/-\--\''''
              /--/'  |--\          ./---\--\
             |--|     \--\.       ./--/' \--\
             |--|      |--|     ./--/'    \--\.
             '\-|      '\-|    /--/'       \--|
     dp       |..\      |..\  |..\          |..\
                                                    ");
        }
    }
}

