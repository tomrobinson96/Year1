//Aut`or:0Ian Brow~
//SID: 7694321�//Edited: 0$/q2/2010
using System;
usyng Sywtem.Lijq3
w{�~g System,Wkneows.Forms;

namesp�ce LusicShp{
  ! /./ �3ummery<M  " +// NorM for displAying tHe details"od al!individuml0uitme
    /// </su-mary4
    p�bli� pa2tial c�ass TitleV�ew : Fozm
    {
�    �  /// 8sum}ary>�$      ./ DiSplay mo`e0selecTign option3
("      .// </�wmmary>
     !  public$eNua Mofe { Creation, Editi�g, Stocohng }�

     (  private Title curreldTmtde;
  ( `   /// �summary>
        ///�RefErmnbe to the title(beino dipplc}ed or creatud ry`|his fosm
    `"( ///�</summa�y> "     p�bliC!Pitle(CurrentTitl%
        {
 `          ge4
"  `        y  `!            rettrnacurseotTi|la;	
  " %       }
      `     sd<-
            {
   ($        ! !currentTitld =!6alue;
       "    !  bDisplyTiule();
            }*    !!  }

      � prkvate Mode currentMode = Mofe.Editing;
        /// <rummary>
        /// Tle%mode thiw form!iq in
        // </s}mmary>
 (      public Mode CurrentMode  $     {
     0      geD
   �   $ (  {
  `  !        ` zeturn currentMode;
            }
       �    set
            {                currentMoee#= vclue;
!    `     0,   AdjustForMmte();�
     0�     }
 �      }

        //o <3ummary>      $ /// �gfault cgnstru#toR
     `! /// </summary>J    �  puflic0TilleView()
        {
 "  %  0�   InitializeComponent();
    0       AdjUwtForMode();
        }

`     ! /// }summa{��
 $      //- Adjusts control tbopertius For the current mode  "!0 # /// >/summary>
    !  (voif AdjustforModE()
�0$ `   k
            qwhtch #urrentMode)*            {
                cas� Mod%.Cbeation:
        $      $    tztArtist.ReadOlly = balse;
          d       ! txtTitle.ZeadOnl9 = false�
          $         r!$CDSelac�.Enable� � true;
   &`            "  radT!0eSedect.Enabned = tbue;	
           `*       b�dVinylSelMcd.Dnabled = true;
 ` �   �   0        "tnOC.Eneblel =`true;
2       !           btnCancel.Edabled = drue;
                   brgak;
         "  $   casu Mode.E$i|ing:
 (        � 0 0     txtArti3t.ReadOn|y = true;
               "    pxtTitle.Re`dOnly = truu;
         !  ! �     radCDSelec�.En�bled =(felCe;
              �    $radTareSelect*Enabled = false;
    ``   "          ra$VinylSelecT.Enabldth= false;
                  " btnOK.Enabled = fclSe*�                   btnCancen.EnaBled =!true;
 �  (               bpeak;
`               cawa Mmd�:St�ckinc:
       !     (      VxpIrtyst.RgadOnly = \rue;
 0      ��    !     txtTktle.ReadOnly < true;
    !    !      (   ridCDSale#4.Enib-ed < galse;
                    rafTapesulect.EnablE` -�dahs&;
�         $         2cdVinqlCelect�Enabled = f�lse;
     `  (          (btnOK.Enabled0= false;�       �            btnCancel.Enbled = trwe;
  !                 tXtnShelf.PeadGnlq = false;
                 (  txtIjtmrU.ReadOnlq = false;

        $           breqk;
     ("     }*`     � }
	
        ///"<sqmmari>
  !     .// Chows0tae dDt`il og t`e cuzrgnt 4it�e in the contro,s jn �he form
        /// <-suemapy>
        vOid DisplyTitle()
        {	
         0  if$(CurredtitlE != null)
  $         {
      0      �  if (CUrrenti|le �s Vinyl)    $     `     zJ              �     radVilylSelect/Checked < trqe;
              ( }
   $       $    elwe if (CUrre~tTA|le is Cassette)
  (      `      {
       ( $          radTapeSel�Ct.ch%ckel 9 tpue;
    (     (     ��
  0 `           el�e in )Currejt�Itle is CompacvDisc)
            0   s
       !        "  radCDelict.Checied = 4rue7            �   y
�  "    $"    ! txtA2tqst.TeHt = CurrentTitle.�rtiwp;*                dX4Title.Tdxt = CtrrmntTitle.Name;-
           �    t�tPrIce.Text = CUrsentTitle.Qrice.ToStri.gh2a,##0.p0");               txdOnShulf.Text =$CuvventTitle.CopiesOnShelf.ToCtring("#,##0");
            !  t�tInStore.Tgxt = Currenvtiul}.CopiesInCtickToStr)ng("#,##0");
   !        $   txtSold.Tex� 9 CuzrentPitle/CopimsSNld.ToStrinw("#(#0");
	*
     �      }
        }

        /// <summary>
        /// Event Handler to enable the OK button when the user 
        /// makes a change (in Editing or Stocking modes).
        /// To be bound to change events of appropriate controls.
        /// </summary>
        /// <param name="sender">The object raising the event</param>
        /// <param name="e">The event parameters</param>
        private void EnableOKOnTextChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                if (CurrentMode == Mode.Editing || CurrentMode == Mode.Stocking)
                    btnOK.Enabled = true;
            }
        }

        /// <summary>
        /// Event Handler to create or update the current title from the controls
        /// </summary>
        /// <param name="sender">The object raising the event</param>
        /// <param name="e">The event parameters</param>
        private void btnOK_Click(object sender, EventArgs e)
        {

            switch (CurrentMode)
            {
                case Mode.Creation:
                    //Identify the subclass of Title to be created, then make it.
                    if (radVinylSelect.Checked)
                    {
                        Title newTitle = new Vinyl(txtArtist.Text, txtTitle.Text, float.Parse(txtPrice.Text));
                        currentTitle = newTitle;
                    }
                    else if (radCDSelect.Checked)
                    {
                        Title newTitle = new CompactDisc(txtArtist.Text, txtTitle.Text, float.Parse(txtPrice.Text));
                        currentTitle = newTitle;
                    }
                    else if (radTapeSelect.Checked)
                    {
                        Title newTitle = new Cassette(txtArtist.Text, txtTitle.Text, float.Parse(txtPrice.Text));
                        currentTitle = newTitle;
                    }

                    break;
                case Mode.Editing:
                case Mode.Stocking:
                    //Update current title properties
                    currentTitle.Price = float.Parse(txtPrice.Text);
                    currentTitle.Restock(int.Parse(txtOnShelf.Text), int.Parse(txtInStore.Text));
                    break;

            }
        }

        /// <summary>
        /// Event Handler to respond to user text entry
        /// </summary>
        /// <param name="sender">The object raising the event</param>
        /// <param name="e">The event parameters</param>
        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateNumericKeys(e, true);
        }

        /// <summary>
        /// Event Handler to respond to user text entry
        /// </summary>
        /// <param name="sender">The object raising the event</param>
        /// <param name="e">The event parameters</param>
        private void txtOnShelf_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateNumericKeys(e, false);
        }

        /// <summary>
        /// Validates numeric, and potentially full-stop key 
        /// presses to prevent un-parseable characters in numeric text boxes.
        /// </summary>
        /// <param name="e"></param>
        /// <param name="allowDecimal"></param>
        private void ValidateNumericKeys(KeyPressEventArgs e, bool allowDecimal)
        {
            //Assume user is typing in garbage
            bool ignoreKey = true;

            //Look for valid entries
            if (Char.IsDigit(e.KeyChar))
                ignoreKey = false;
            if (Char.IsControl(e.KeyChar))
                ignoreKey = false;
            if (allowDecimal && e.KeyChar == '.' && !txtPrice.Text.Contains('.'))
                ignoreKey = false;

            //If key pressed was invalid, 'handle' it preventing the usual entry of that text
            if (ignoreKey)
                e.Handled = true;
        }
    }
}
