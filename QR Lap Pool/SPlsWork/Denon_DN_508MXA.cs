using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using Crestron;
using Crestron.Logos.SplusLibrary;
using Crestron.Logos.SplusObjects;
using Crestron.SimplSharp;

namespace UserModule_DENON_DN_508MXA
{
    public class UserModuleClass_DENON_DN_508MXA : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        Crestron.Logos.SplusObjects.DigitalInput POLL_ALL;
        Crestron.Logos.SplusObjects.AnalogInput ZONE_1_SOURCE;
        Crestron.Logos.SplusObjects.AnalogInput ZONE_2_SOURCE;
        Crestron.Logos.SplusObjects.AnalogInput ZONE_3_SOURCE;
        Crestron.Logos.SplusObjects.AnalogInput ZONE_4_SOURCE;
        Crestron.Logos.SplusObjects.AnalogInput ZONE_5_SOURCE;
        Crestron.Logos.SplusObjects.AnalogInput ZONE_6_SOURCE;
        Crestron.Logos.SplusObjects.AnalogInput ZONE_7_SOURCE;
        Crestron.Logos.SplusObjects.AnalogInput ZONE_8_SOURCE;
        Crestron.Logos.SplusObjects.AnalogInput ZONE_1_SOURCE_VOLUME;
        Crestron.Logos.SplusObjects.AnalogInput ZONE_2_SOURCE_VOLUME;
        Crestron.Logos.SplusObjects.AnalogInput ZONE_3_SOURCE_VOLUME;
        Crestron.Logos.SplusObjects.AnalogInput ZONE_4_SOURCE_VOLUME;
        Crestron.Logos.SplusObjects.AnalogInput ZONE_5_SOURCE_VOLUME;
        Crestron.Logos.SplusObjects.AnalogInput ZONE_6_SOURCE_VOLUME;
        Crestron.Logos.SplusObjects.AnalogInput ZONE_7_SOURCE_VOLUME;
        Crestron.Logos.SplusObjects.AnalogInput ZONE_8_SOURCE_VOLUME;
        Crestron.Logos.SplusObjects.AnalogInput ZONE_1_MICLINE_VOLUME;
        Crestron.Logos.SplusObjects.AnalogInput ZONE_2_MICLINE_VOLUME;
        Crestron.Logos.SplusObjects.AnalogInput ZONE_3_MICLINE_VOLUME;
        Crestron.Logos.SplusObjects.AnalogInput ZONE_4_MICLINE_VOLUME;
        Crestron.Logos.SplusObjects.AnalogInput ZONE_5_MICLINE_VOLUME;
        Crestron.Logos.SplusObjects.AnalogInput ZONE_6_MICLINE_VOLUME;
        Crestron.Logos.SplusObjects.AnalogInput ZONE_7_MICLINE_VOLUME;
        Crestron.Logos.SplusObjects.AnalogInput ZONE_8_MICLINE_VOLUME;
        Crestron.Logos.SplusObjects.AnalogInput ZONE_1_MASTER_VOLUME;
        Crestron.Logos.SplusObjects.AnalogInput ZONE_2_MASTER_VOLUME;
        Crestron.Logos.SplusObjects.AnalogInput ZONE_3_MASTER_VOLUME;
        Crestron.Logos.SplusObjects.AnalogInput ZONE_4_MASTER_VOLUME;
        Crestron.Logos.SplusObjects.AnalogInput ZONE_5_MASTER_VOLUME;
        Crestron.Logos.SplusObjects.AnalogInput ZONE_6_MASTER_VOLUME;
        Crestron.Logos.SplusObjects.AnalogInput ZONE_7_MASTER_VOLUME;
        Crestron.Logos.SplusObjects.AnalogInput ZONE_8_MASTER_VOLUME;
        Crestron.Logos.SplusObjects.AnalogInput ZONE_1_MASTER_MUTE;
        Crestron.Logos.SplusObjects.AnalogInput ZONE_2_MASTER_MUTE;
        Crestron.Logos.SplusObjects.AnalogInput ZONE_3_MASTER_MUTE;
        Crestron.Logos.SplusObjects.AnalogInput ZONE_4_MASTER_MUTE;
        Crestron.Logos.SplusObjects.AnalogInput ZONE_5_MASTER_MUTE;
        Crestron.Logos.SplusObjects.AnalogInput ZONE_6_MASTER_MUTE;
        Crestron.Logos.SplusObjects.AnalogInput ZONE_7_MASTER_MUTE;
        Crestron.Logos.SplusObjects.AnalogInput ZONE_8_MASTER_MUTE;
        Crestron.Logos.SplusObjects.StringInput DENON_RX__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DENON_TX__DOLLAR__;
        CrestronString SERIALCOMMAND;
        short NVOLUME_SCALED = 0;
        short SIVOLUME = 0;
        object ZONE_1_SOURCE_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 84;
                if ( Functions.TestForTrue  ( ( ZONE_1_SOURCE  .UshortValue)  ) ) 
                    { 
                    __context__.SourceCodeLine = 86;
                    MakeString ( DENON_TX__DOLLAR__ , "@0PXOT1SS{0}\u000D", Functions.LtoA (  (int) ( ZONE_1_SOURCE  .UshortValue ) ) ) ; 
                    __context__.SourceCodeLine = 87;
                    MakeString ( DENON_TX__DOLLAR__ , "@0?PXOT1SS<CR>\u000D") ; 
                    } 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object ZONE_2_SOURCE_OnChange_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 93;
            if ( Functions.TestForTrue  ( ( ZONE_2_SOURCE  .UshortValue)  ) ) 
                { 
                __context__.SourceCodeLine = 95;
                MakeString ( DENON_TX__DOLLAR__ , "@0PXOT2SS{0}\u000D", Functions.LtoA (  (int) ( ZONE_2_SOURCE  .UshortValue ) ) ) ; 
                __context__.SourceCodeLine = 96;
                MakeString ( DENON_TX__DOLLAR__ , "@0?PXOT2SS<CR>\u000D") ; 
                } 
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object ZONE_3_SOURCE_OnChange_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 102;
        if ( Functions.TestForTrue  ( ( ZONE_3_SOURCE  .UshortValue)  ) ) 
            { 
            __context__.SourceCodeLine = 104;
            MakeString ( DENON_TX__DOLLAR__ , "@0PXOT3SS{0}\u000D", Functions.LtoA (  (int) ( ZONE_3_SOURCE  .UshortValue ) ) ) ; 
            __context__.SourceCodeLine = 105;
            MakeString ( DENON_TX__DOLLAR__ , "@0?PXOT3SS<CR>\u000D") ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ZONE_4_SOURCE_OnChange_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 111;
        if ( Functions.TestForTrue  ( ( ZONE_4_SOURCE  .UshortValue)  ) ) 
            { 
            __context__.SourceCodeLine = 113;
            MakeString ( DENON_TX__DOLLAR__ , "@0PXOT4SS{0}\u000D", Functions.LtoA (  (int) ( ZONE_4_SOURCE  .UshortValue ) ) ) ; 
            __context__.SourceCodeLine = 114;
            MakeString ( DENON_TX__DOLLAR__ , "@0?PXOT4SS<CR>\u000D") ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ZONE_5_SOURCE_OnChange_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 120;
        if ( Functions.TestForTrue  ( ( ZONE_5_SOURCE  .UshortValue)  ) ) 
            { 
            __context__.SourceCodeLine = 122;
            MakeString ( DENON_TX__DOLLAR__ , "@0PXOT5SS{0}\u000D", Functions.LtoA (  (int) ( ZONE_5_SOURCE  .UshortValue ) ) ) ; 
            __context__.SourceCodeLine = 123;
            MakeString ( DENON_TX__DOLLAR__ , "@0?PXOT5SS<CR>\u000D") ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ZONE_6_SOURCE_OnChange_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 129;
        if ( Functions.TestForTrue  ( ( ZONE_6_SOURCE  .UshortValue)  ) ) 
            { 
            __context__.SourceCodeLine = 131;
            MakeString ( DENON_TX__DOLLAR__ , "@0PXOT6SS{0}\u000D", Functions.LtoA (  (int) ( ZONE_6_SOURCE  .UshortValue ) ) ) ; 
            __context__.SourceCodeLine = 132;
            MakeString ( DENON_TX__DOLLAR__ , "@0?PXOT6SS<CR>\u000D") ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ZONE_7_SOURCE_OnChange_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 138;
        if ( Functions.TestForTrue  ( ( ZONE_7_SOURCE  .UshortValue)  ) ) 
            { 
            __context__.SourceCodeLine = 140;
            MakeString ( DENON_TX__DOLLAR__ , "@0PXOT7SS{0}\u000D", Functions.LtoA (  (int) ( ZONE_7_SOURCE  .UshortValue ) ) ) ; 
            __context__.SourceCodeLine = 141;
            MakeString ( DENON_TX__DOLLAR__ , "@0?PXOT7SS<CR>\u000D") ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ZONE_8_SOURCE_OnChange_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 147;
        if ( Functions.TestForTrue  ( ( ZONE_8_SOURCE  .UshortValue)  ) ) 
            { 
            __context__.SourceCodeLine = 149;
            MakeString ( DENON_TX__DOLLAR__ , "@0PXOT8SS{0}\u000D", Functions.LtoA (  (int) ( ZONE_8_SOURCE  .UshortValue ) ) ) ; 
            __context__.SourceCodeLine = 150;
            MakeString ( DENON_TX__DOLLAR__ , "@0?PXOT8SS<CR>\u000D") ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ZONE_1_SOURCE_VOLUME_OnChange_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 156;
        if ( Functions.TestForTrue  ( ( ZONE_1_SOURCE_VOLUME  .UshortValue)  ) ) 
            { 
            __context__.SourceCodeLine = 158;
            NVOLUME_SCALED = (short) ( ((ZONE_1_SOURCE_VOLUME  .ShortValue * 100) / 65535) ) ; 
            __context__.SourceCodeLine = 159;
            Trace( "nVolume_Scaled: {0:d}\r\n", (ushort)NVOLUME_SCALED) ; 
            __context__.SourceCodeLine = 162;
            SIVOLUME = (short) ( (NVOLUME_SCALED - 90) ) ; 
            __context__.SourceCodeLine = 163;
            Trace( "siVolume: {0:d}\r\n", (ushort)SIVOLUME) ; 
            __context__.SourceCodeLine = 165;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SIVOLUME >= 0 ))  ) ) 
                {
                __context__.SourceCodeLine = 166;
                MakeString ( DENON_TX__DOLLAR__ , "@0PXOT1SL{0}.0\u000D", Functions.LtoA (  (int) ( SIVOLUME ) ) ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 167;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SIVOLUME == Functions.ToSignedLongInteger( -( 90 ) )))  ) ) 
                    {
                    __context__.SourceCodeLine = 168;
                    MakeString ( DENON_TX__DOLLAR__ , "@0PXOT1SLInf\u000D") ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 170;
                    MakeString ( DENON_TX__DOLLAR__ , "@0PXOT1SL-{0}.0\u000D", Functions.LtoA (  (int) ( SIVOLUME ) ) ) ; 
                    }
                
                }
            
            __context__.SourceCodeLine = 172;
            MakeString ( DENON_TX__DOLLAR__ , "@0?PXOT1SL<CR>\u000D") ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ZONE_2_SOURCE_VOLUME_OnChange_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 178;
        if ( Functions.TestForTrue  ( ( ZONE_2_SOURCE_VOLUME  .UshortValue)  ) ) 
            { 
            __context__.SourceCodeLine = 180;
            NVOLUME_SCALED = (short) ( ((ZONE_2_SOURCE_VOLUME  .ShortValue * 100) / 65535) ) ; 
            __context__.SourceCodeLine = 181;
            SIVOLUME = (short) ( (NVOLUME_SCALED - 90) ) ; 
            __context__.SourceCodeLine = 183;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SIVOLUME >= 0 ))  ) ) 
                {
                __context__.SourceCodeLine = 184;
                MakeString ( DENON_TX__DOLLAR__ , "@0PXOT2SL{0}.0\u000D", Functions.LtoA (  (int) ( SIVOLUME ) ) ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 185;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SIVOLUME == Functions.ToSignedLongInteger( -( 90 ) )))  ) ) 
                    {
                    __context__.SourceCodeLine = 186;
                    MakeString ( DENON_TX__DOLLAR__ , "@0PXOT2SLInf\u000D") ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 188;
                    MakeString ( DENON_TX__DOLLAR__ , "@0PXOT2SL-{0}.0\u000D", Functions.LtoA (  (int) ( SIVOLUME ) ) ) ; 
                    }
                
                }
            
            __context__.SourceCodeLine = 190;
            MakeString ( DENON_TX__DOLLAR__ , "@0?PXOT2SL<CR>\u000D") ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ZONE_3_SOURCE_VOLUME_OnChange_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 197;
        if ( Functions.TestForTrue  ( ( ZONE_3_SOURCE_VOLUME  .UshortValue)  ) ) 
            { 
            __context__.SourceCodeLine = 199;
            NVOLUME_SCALED = (short) ( ((ZONE_3_SOURCE_VOLUME  .ShortValue * 100) / 65535) ) ; 
            __context__.SourceCodeLine = 200;
            SIVOLUME = (short) ( (NVOLUME_SCALED - 90) ) ; 
            __context__.SourceCodeLine = 202;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SIVOLUME >= 0 ))  ) ) 
                {
                __context__.SourceCodeLine = 203;
                MakeString ( DENON_TX__DOLLAR__ , "@0PXOT3SL{0}.0\u000D", Functions.LtoA (  (int) ( SIVOLUME ) ) ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 204;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SIVOLUME == Functions.ToSignedLongInteger( -( 90 ) )))  ) ) 
                    {
                    __context__.SourceCodeLine = 205;
                    MakeString ( DENON_TX__DOLLAR__ , "@0PXOT3SLInf\u000D") ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 207;
                    MakeString ( DENON_TX__DOLLAR__ , "@0PXOT3SL-{0}.0\u000D", Functions.LtoA (  (int) ( SIVOLUME ) ) ) ; 
                    }
                
                }
            
            __context__.SourceCodeLine = 209;
            MakeString ( DENON_TX__DOLLAR__ , "@0?PXOT3SL<CR>\u000D") ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ZONE_4_SOURCE_VOLUME_OnChange_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 215;
        if ( Functions.TestForTrue  ( ( ZONE_4_SOURCE_VOLUME  .UshortValue)  ) ) 
            { 
            __context__.SourceCodeLine = 217;
            NVOLUME_SCALED = (short) ( ((ZONE_4_SOURCE_VOLUME  .ShortValue * 100) / 65535) ) ; 
            __context__.SourceCodeLine = 218;
            SIVOLUME = (short) ( (NVOLUME_SCALED - 90) ) ; 
            __context__.SourceCodeLine = 220;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SIVOLUME >= 0 ))  ) ) 
                {
                __context__.SourceCodeLine = 221;
                MakeString ( DENON_TX__DOLLAR__ , "@0PXOT4SL{0}.0\u000D", Functions.LtoA (  (int) ( SIVOLUME ) ) ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 222;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SIVOLUME == Functions.ToSignedLongInteger( -( 90 ) )))  ) ) 
                    {
                    __context__.SourceCodeLine = 223;
                    MakeString ( DENON_TX__DOLLAR__ , "@0PXOT4SLInf\u000D") ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 225;
                    MakeString ( DENON_TX__DOLLAR__ , "@0PXOT4SL-{0}.0\u000D", Functions.LtoA (  (int) ( SIVOLUME ) ) ) ; 
                    }
                
                }
            
            __context__.SourceCodeLine = 227;
            MakeString ( DENON_TX__DOLLAR__ , "@0?PXOT4SL<CR>\u000D") ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ZONE_5_SOURCE_VOLUME_OnChange_12 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 233;
        if ( Functions.TestForTrue  ( ( ZONE_5_SOURCE_VOLUME  .UshortValue)  ) ) 
            { 
            __context__.SourceCodeLine = 235;
            NVOLUME_SCALED = (short) ( ((ZONE_5_SOURCE_VOLUME  .ShortValue * 100) / 65535) ) ; 
            __context__.SourceCodeLine = 236;
            SIVOLUME = (short) ( (NVOLUME_SCALED - 90) ) ; 
            __context__.SourceCodeLine = 238;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SIVOLUME >= 0 ))  ) ) 
                {
                __context__.SourceCodeLine = 239;
                MakeString ( DENON_TX__DOLLAR__ , "@0PXOT5SL{0}.0\u000D", Functions.LtoA (  (int) ( SIVOLUME ) ) ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 240;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SIVOLUME == Functions.ToSignedLongInteger( -( 90 ) )))  ) ) 
                    {
                    __context__.SourceCodeLine = 241;
                    MakeString ( DENON_TX__DOLLAR__ , "@0PXOT5SLInf\u000D") ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 243;
                    MakeString ( DENON_TX__DOLLAR__ , "@0PXOT5SL-{0}.0\u000D", Functions.LtoA (  (int) ( SIVOLUME ) ) ) ; 
                    }
                
                }
            
            __context__.SourceCodeLine = 245;
            MakeString ( DENON_TX__DOLLAR__ , "@0?PXOT5SL<CR>\u000D") ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ZONE_6_SOURCE_VOLUME_OnChange_13 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 251;
        if ( Functions.TestForTrue  ( ( ZONE_6_SOURCE_VOLUME  .UshortValue)  ) ) 
            { 
            __context__.SourceCodeLine = 253;
            NVOLUME_SCALED = (short) ( ((ZONE_6_SOURCE_VOLUME  .ShortValue * 100) / 65535) ) ; 
            __context__.SourceCodeLine = 254;
            SIVOLUME = (short) ( (NVOLUME_SCALED - 90) ) ; 
            __context__.SourceCodeLine = 256;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SIVOLUME >= 0 ))  ) ) 
                {
                __context__.SourceCodeLine = 257;
                MakeString ( DENON_TX__DOLLAR__ , "@0PXOT6SL{0}.0\u000D", Functions.LtoA (  (int) ( SIVOLUME ) ) ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 258;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SIVOLUME == Functions.ToSignedLongInteger( -( 90 ) )))  ) ) 
                    {
                    __context__.SourceCodeLine = 259;
                    MakeString ( DENON_TX__DOLLAR__ , "@0PXOT6SLInf\u000D") ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 261;
                    MakeString ( DENON_TX__DOLLAR__ , "@0PXOT6SL-{0}.0\u000D", Functions.LtoA (  (int) ( SIVOLUME ) ) ) ; 
                    }
                
                }
            
            __context__.SourceCodeLine = 263;
            MakeString ( DENON_TX__DOLLAR__ , "@0?PXOT6SL<CR>\u000D") ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ZONE_7_SOURCE_VOLUME_OnChange_14 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 270;
        if ( Functions.TestForTrue  ( ( ZONE_7_SOURCE_VOLUME  .UshortValue)  ) ) 
            { 
            __context__.SourceCodeLine = 272;
            NVOLUME_SCALED = (short) ( ((ZONE_7_SOURCE_VOLUME  .ShortValue * 100) / 65535) ) ; 
            __context__.SourceCodeLine = 273;
            SIVOLUME = (short) ( (NVOLUME_SCALED - 90) ) ; 
            __context__.SourceCodeLine = 275;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SIVOLUME >= 0 ))  ) ) 
                {
                __context__.SourceCodeLine = 276;
                MakeString ( DENON_TX__DOLLAR__ , "@0PXOT7SL{0}.0\u000D", Functions.LtoA (  (int) ( SIVOLUME ) ) ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 277;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SIVOLUME == Functions.ToSignedLongInteger( -( 90 ) )))  ) ) 
                    {
                    __context__.SourceCodeLine = 278;
                    MakeString ( DENON_TX__DOLLAR__ , "@0PXOT7SLInf\u000D") ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 280;
                    MakeString ( DENON_TX__DOLLAR__ , "@0PXOT7SL-{0}.0\u000D", Functions.LtoA (  (int) ( SIVOLUME ) ) ) ; 
                    }
                
                }
            
            __context__.SourceCodeLine = 282;
            MakeString ( DENON_TX__DOLLAR__ , "@0?PXOT7SL<CR>\u000D") ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ZONE_8_SOURCE_VOLUME_OnChange_15 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 288;
        if ( Functions.TestForTrue  ( ( ZONE_8_SOURCE_VOLUME  .UshortValue)  ) ) 
            { 
            __context__.SourceCodeLine = 290;
            NVOLUME_SCALED = (short) ( ((ZONE_8_SOURCE_VOLUME  .ShortValue * 100) / 65535) ) ; 
            __context__.SourceCodeLine = 291;
            SIVOLUME = (short) ( (NVOLUME_SCALED - 90) ) ; 
            __context__.SourceCodeLine = 293;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SIVOLUME >= 0 ))  ) ) 
                {
                __context__.SourceCodeLine = 294;
                MakeString ( DENON_TX__DOLLAR__ , "@0PXOT8SL{0}.0\u000D", Functions.LtoA (  (int) ( SIVOLUME ) ) ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 295;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SIVOLUME == Functions.ToSignedLongInteger( -( 90 ) )))  ) ) 
                    {
                    __context__.SourceCodeLine = 296;
                    MakeString ( DENON_TX__DOLLAR__ , "@0PXOT8SLInf\u000D") ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 298;
                    MakeString ( DENON_TX__DOLLAR__ , "@0PXOT8SL-{0}.0\u000D", Functions.LtoA (  (int) ( SIVOLUME ) ) ) ; 
                    }
                
                }
            
            __context__.SourceCodeLine = 300;
            MakeString ( DENON_TX__DOLLAR__ , "@0?PXOT8SL<CR>\u000D") ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ZONE_1_MICLINE_VOLUME_OnChange_16 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 306;
        if ( Functions.TestForTrue  ( ( ZONE_1_MICLINE_VOLUME  .UshortValue)  ) ) 
            { 
            __context__.SourceCodeLine = 308;
            NVOLUME_SCALED = (short) ( ((ZONE_1_MICLINE_VOLUME  .ShortValue * 100) / 65535) ) ; 
            __context__.SourceCodeLine = 309;
            SIVOLUME = (short) ( (NVOLUME_SCALED - 90) ) ; 
            __context__.SourceCodeLine = 311;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SIVOLUME >= 0 ))  ) ) 
                {
                __context__.SourceCodeLine = 312;
                MakeString ( DENON_TX__DOLLAR__ , "@0PXOT1ML{0}.0\u000D", Functions.LtoA (  (int) ( SIVOLUME ) ) ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 313;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SIVOLUME == Functions.ToSignedLongInteger( -( 90 ) )))  ) ) 
                    {
                    __context__.SourceCodeLine = 314;
                    MakeString ( DENON_TX__DOLLAR__ , "@0PXOT1MLInf\u000D") ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 316;
                    MakeString ( DENON_TX__DOLLAR__ , "@0PXOT1ML-{0}.0\u000D", Functions.LtoA (  (int) ( SIVOLUME ) ) ) ; 
                    }
                
                }
            
            __context__.SourceCodeLine = 318;
            MakeString ( DENON_TX__DOLLAR__ , "@0?PXOT1ML<CR>\u000D") ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ZONE_2_MICLINE_VOLUME_OnChange_17 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 324;
        if ( Functions.TestForTrue  ( ( ZONE_2_MICLINE_VOLUME  .UshortValue)  ) ) 
            { 
            __context__.SourceCodeLine = 326;
            NVOLUME_SCALED = (short) ( ((ZONE_2_MICLINE_VOLUME  .ShortValue * 100) / 65535) ) ; 
            __context__.SourceCodeLine = 327;
            SIVOLUME = (short) ( (NVOLUME_SCALED - 90) ) ; 
            __context__.SourceCodeLine = 329;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SIVOLUME >= 0 ))  ) ) 
                {
                __context__.SourceCodeLine = 330;
                MakeString ( DENON_TX__DOLLAR__ , "@0PXOT2ML{0}.0\u000D", Functions.LtoA (  (int) ( SIVOLUME ) ) ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 331;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SIVOLUME == Functions.ToSignedLongInteger( -( 90 ) )))  ) ) 
                    {
                    __context__.SourceCodeLine = 332;
                    MakeString ( DENON_TX__DOLLAR__ , "@0PXOT2MLInf\u000D") ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 334;
                    MakeString ( DENON_TX__DOLLAR__ , "@0PXOT2ML-{0}.0\u000D", Functions.LtoA (  (int) ( SIVOLUME ) ) ) ; 
                    }
                
                }
            
            __context__.SourceCodeLine = 336;
            MakeString ( DENON_TX__DOLLAR__ , "@0?PXOT2ML<CR>\u000D") ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ZONE_3_MICLINE_VOLUME_OnChange_18 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 343;
        if ( Functions.TestForTrue  ( ( ZONE_3_MICLINE_VOLUME  .UshortValue)  ) ) 
            { 
            __context__.SourceCodeLine = 345;
            NVOLUME_SCALED = (short) ( ((ZONE_3_MICLINE_VOLUME  .ShortValue * 100) / 65535) ) ; 
            __context__.SourceCodeLine = 346;
            SIVOLUME = (short) ( (NVOLUME_SCALED - 90) ) ; 
            __context__.SourceCodeLine = 348;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SIVOLUME >= 0 ))  ) ) 
                {
                __context__.SourceCodeLine = 349;
                MakeString ( DENON_TX__DOLLAR__ , "@0PXOT3ML{0}.0\u000D", Functions.LtoA (  (int) ( SIVOLUME ) ) ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 350;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SIVOLUME == Functions.ToSignedLongInteger( -( 90 ) )))  ) ) 
                    {
                    __context__.SourceCodeLine = 351;
                    MakeString ( DENON_TX__DOLLAR__ , "@0PXOT3MLInf\u000D") ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 353;
                    MakeString ( DENON_TX__DOLLAR__ , "@0PXOT3ML-{0}.0\u000D", Functions.LtoA (  (int) ( SIVOLUME ) ) ) ; 
                    }
                
                }
            
            __context__.SourceCodeLine = 355;
            MakeString ( DENON_TX__DOLLAR__ , "@0?PXOT3ML<CR>\u000D") ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ZONE_4_MICLINE_VOLUME_OnChange_19 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 361;
        if ( Functions.TestForTrue  ( ( ZONE_4_MICLINE_VOLUME  .UshortValue)  ) ) 
            { 
            __context__.SourceCodeLine = 363;
            NVOLUME_SCALED = (short) ( ((ZONE_4_MICLINE_VOLUME  .ShortValue * 100) / 65535) ) ; 
            __context__.SourceCodeLine = 364;
            SIVOLUME = (short) ( (NVOLUME_SCALED - 90) ) ; 
            __context__.SourceCodeLine = 366;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SIVOLUME >= 0 ))  ) ) 
                {
                __context__.SourceCodeLine = 367;
                MakeString ( DENON_TX__DOLLAR__ , "@0PXOT4ML{0}.0\u000D", Functions.LtoA (  (int) ( SIVOLUME ) ) ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 368;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SIVOLUME == Functions.ToSignedLongInteger( -( 90 ) )))  ) ) 
                    {
                    __context__.SourceCodeLine = 369;
                    MakeString ( DENON_TX__DOLLAR__ , "@0PXOT4MLInf\u000D") ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 371;
                    MakeString ( DENON_TX__DOLLAR__ , "@0PXOT4ML-{0}.0\u000D", Functions.LtoA (  (int) ( SIVOLUME ) ) ) ; 
                    }
                
                }
            
            __context__.SourceCodeLine = 373;
            MakeString ( DENON_TX__DOLLAR__ , "@0?PXOT4ML<CR>\u000D") ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ZONE_5_MICLINE_VOLUME_OnChange_20 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 379;
        if ( Functions.TestForTrue  ( ( ZONE_5_MICLINE_VOLUME  .UshortValue)  ) ) 
            { 
            __context__.SourceCodeLine = 381;
            NVOLUME_SCALED = (short) ( ((ZONE_5_MICLINE_VOLUME  .ShortValue * 100) / 65535) ) ; 
            __context__.SourceCodeLine = 382;
            SIVOLUME = (short) ( (NVOLUME_SCALED - 90) ) ; 
            __context__.SourceCodeLine = 384;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SIVOLUME >= 0 ))  ) ) 
                {
                __context__.SourceCodeLine = 385;
                MakeString ( DENON_TX__DOLLAR__ , "@0PXOT5ML{0}.0\u000D", Functions.LtoA (  (int) ( SIVOLUME ) ) ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 386;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SIVOLUME == Functions.ToSignedLongInteger( -( 90 ) )))  ) ) 
                    {
                    __context__.SourceCodeLine = 387;
                    MakeString ( DENON_TX__DOLLAR__ , "@0PXOT5MLInf\u000D") ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 389;
                    MakeString ( DENON_TX__DOLLAR__ , "@0PXOT5ML-{0}.0\u000D", Functions.LtoA (  (int) ( SIVOLUME ) ) ) ; 
                    }
                
                }
            
            __context__.SourceCodeLine = 391;
            MakeString ( DENON_TX__DOLLAR__ , "@0?PXOT5ML<CR>\u000D") ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ZONE_6_MICLINE_VOLUME_OnChange_21 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 397;
        if ( Functions.TestForTrue  ( ( ZONE_6_MICLINE_VOLUME  .UshortValue)  ) ) 
            { 
            __context__.SourceCodeLine = 399;
            NVOLUME_SCALED = (short) ( ((ZONE_6_MICLINE_VOLUME  .ShortValue * 100) / 65535) ) ; 
            __context__.SourceCodeLine = 400;
            SIVOLUME = (short) ( (NVOLUME_SCALED - 90) ) ; 
            __context__.SourceCodeLine = 402;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SIVOLUME >= 0 ))  ) ) 
                {
                __context__.SourceCodeLine = 403;
                MakeString ( DENON_TX__DOLLAR__ , "@0PXOT6ML{0}.0\u000D", Functions.LtoA (  (int) ( SIVOLUME ) ) ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 404;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SIVOLUME == Functions.ToSignedLongInteger( -( 90 ) )))  ) ) 
                    {
                    __context__.SourceCodeLine = 405;
                    MakeString ( DENON_TX__DOLLAR__ , "@0PXOT6MLInf\u000D") ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 407;
                    MakeString ( DENON_TX__DOLLAR__ , "@0PXOT6ML-{0}.0\u000D", Functions.LtoA (  (int) ( SIVOLUME ) ) ) ; 
                    }
                
                }
            
            __context__.SourceCodeLine = 409;
            MakeString ( DENON_TX__DOLLAR__ , "@0?PXOT6ML<CR>\u000D") ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ZONE_7_MICLINE_VOLUME_OnChange_22 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 416;
        if ( Functions.TestForTrue  ( ( ZONE_7_MICLINE_VOLUME  .UshortValue)  ) ) 
            { 
            __context__.SourceCodeLine = 418;
            NVOLUME_SCALED = (short) ( ((ZONE_7_MICLINE_VOLUME  .ShortValue * 100) / 65535) ) ; 
            __context__.SourceCodeLine = 419;
            SIVOLUME = (short) ( (NVOLUME_SCALED - 90) ) ; 
            __context__.SourceCodeLine = 421;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SIVOLUME >= 0 ))  ) ) 
                {
                __context__.SourceCodeLine = 422;
                MakeString ( DENON_TX__DOLLAR__ , "@0PXOT7ML{0}.0\u000D", Functions.LtoA (  (int) ( SIVOLUME ) ) ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 423;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SIVOLUME == Functions.ToSignedLongInteger( -( 90 ) )))  ) ) 
                    {
                    __context__.SourceCodeLine = 424;
                    MakeString ( DENON_TX__DOLLAR__ , "@0PXOT7MLInf\u000D") ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 426;
                    MakeString ( DENON_TX__DOLLAR__ , "@0PXOT7ML-{0}.0\u000D", Functions.LtoA (  (int) ( SIVOLUME ) ) ) ; 
                    }
                
                }
            
            __context__.SourceCodeLine = 428;
            MakeString ( DENON_TX__DOLLAR__ , "@0?PXOT7ML<CR>\u000D") ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ZONE_8_MICLINE_VOLUME_OnChange_23 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 434;
        if ( Functions.TestForTrue  ( ( ZONE_8_MICLINE_VOLUME  .UshortValue)  ) ) 
            { 
            __context__.SourceCodeLine = 436;
            NVOLUME_SCALED = (short) ( ((ZONE_8_MICLINE_VOLUME  .ShortValue * 100) / 65535) ) ; 
            __context__.SourceCodeLine = 437;
            SIVOLUME = (short) ( (NVOLUME_SCALED - 90) ) ; 
            __context__.SourceCodeLine = 439;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SIVOLUME >= 0 ))  ) ) 
                {
                __context__.SourceCodeLine = 440;
                MakeString ( DENON_TX__DOLLAR__ , "@0PXOT8ML{0}.0\u000D", Functions.LtoA (  (int) ( SIVOLUME ) ) ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 441;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SIVOLUME == Functions.ToSignedLongInteger( -( 90 ) )))  ) ) 
                    {
                    __context__.SourceCodeLine = 442;
                    MakeString ( DENON_TX__DOLLAR__ , "@0PXOT8MLInf\u000D") ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 444;
                    MakeString ( DENON_TX__DOLLAR__ , "@0PXOT8ML-{0}.0\u000D", Functions.LtoA (  (int) ( SIVOLUME ) ) ) ; 
                    }
                
                }
            
            __context__.SourceCodeLine = 446;
            MakeString ( DENON_TX__DOLLAR__ , "@0?PXOT8ML<CR>\u000D") ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ZONE_1_MASTER_VOLUME_OnChange_24 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 452;
        if ( Functions.TestForTrue  ( ( ZONE_1_MASTER_VOLUME  .UshortValue)  ) ) 
            { 
            __context__.SourceCodeLine = 454;
            NVOLUME_SCALED = (short) ( ((ZONE_1_MASTER_VOLUME  .ShortValue * 100) / 32768) ) ; 
            __context__.SourceCodeLine = 455;
            Trace( "nVolume_Scaled: {0:d}\r\n", (uint)NVOLUME_SCALED) ; 
            __context__.SourceCodeLine = 457;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NVOLUME_SCALED >= 90 ))  ) ) 
                {
                __context__.SourceCodeLine = 458;
                MakeString ( DENON_TX__DOLLAR__ , "@0PXOT1LV{0}.0\u000D", Functions.LtoA (  (int) ( (NVOLUME_SCALED - 90) ) ) ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 459;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (NVOLUME_SCALED == 0))  ) ) 
                    {
                    __context__.SourceCodeLine = 460;
                    MakeString ( DENON_TX__DOLLAR__ , "@0PXOT1LVInf\u000D") ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 462;
                    MakeString ( DENON_TX__DOLLAR__ , "@0PXOT1LV-{0}.0\u000D", Functions.LtoA (  (int) ( (90 - NVOLUME_SCALED) ) ) ) ; 
                    }
                
                }
            
            __context__.SourceCodeLine = 464;
            MakeString ( DENON_TX__DOLLAR__ , "@0?PXOT1LV<CR>\u000D") ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ZONE_2_MASTER_VOLUME_OnChange_25 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 470;
        if ( Functions.TestForTrue  ( ( ZONE_2_MASTER_VOLUME  .UshortValue)  ) ) 
            { 
            __context__.SourceCodeLine = 472;
            NVOLUME_SCALED = (short) ( ((ZONE_2_MASTER_VOLUME  .ShortValue * 100) / 32768) ) ; 
            __context__.SourceCodeLine = 473;
            Trace( "nVolume_Scaled: {0:d}\r\n", (uint)NVOLUME_SCALED) ; 
            __context__.SourceCodeLine = 475;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NVOLUME_SCALED >= 90 ))  ) ) 
                {
                __context__.SourceCodeLine = 476;
                MakeString ( DENON_TX__DOLLAR__ , "@0PXOT2LV{0}.0\u000D", Functions.LtoA (  (int) ( (NVOLUME_SCALED - 90) ) ) ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 477;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (NVOLUME_SCALED == 0))  ) ) 
                    {
                    __context__.SourceCodeLine = 478;
                    MakeString ( DENON_TX__DOLLAR__ , "@0PXOT2LVInf\u000D") ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 480;
                    MakeString ( DENON_TX__DOLLAR__ , "@0PXOT2LV-{0}.0\u000D", Functions.LtoA (  (int) ( (90 - NVOLUME_SCALED) ) ) ) ; 
                    }
                
                }
            
            __context__.SourceCodeLine = 482;
            MakeString ( DENON_TX__DOLLAR__ , "@0?PXOT2LV<CR>\u000D") ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ZONE_3_MASTER_VOLUME_OnChange_26 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 489;
        if ( Functions.TestForTrue  ( ( ZONE_3_MASTER_VOLUME  .UshortValue)  ) ) 
            { 
            __context__.SourceCodeLine = 491;
            NVOLUME_SCALED = (short) ( ((ZONE_3_MASTER_VOLUME  .ShortValue * 100) / 32768) ) ; 
            __context__.SourceCodeLine = 492;
            Trace( "nVolume_Scaled: {0:d}\r\n", (uint)NVOLUME_SCALED) ; 
            __context__.SourceCodeLine = 494;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NVOLUME_SCALED >= 90 ))  ) ) 
                {
                __context__.SourceCodeLine = 495;
                MakeString ( DENON_TX__DOLLAR__ , "@0PXOT3LV{0}.0\u000D", Functions.LtoA (  (int) ( (NVOLUME_SCALED - 90) ) ) ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 496;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (NVOLUME_SCALED == 0))  ) ) 
                    {
                    __context__.SourceCodeLine = 497;
                    MakeString ( DENON_TX__DOLLAR__ , "@0PXOT3LVInf\u000D") ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 499;
                    MakeString ( DENON_TX__DOLLAR__ , "@0PXOT3LV-{0}.0\u000D", Functions.LtoA (  (int) ( (90 - NVOLUME_SCALED) ) ) ) ; 
                    }
                
                }
            
            __context__.SourceCodeLine = 501;
            MakeString ( DENON_TX__DOLLAR__ , "@0?PXOT3LV<CR>\u000D") ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ZONE_4_MASTER_VOLUME_OnChange_27 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 507;
        if ( Functions.TestForTrue  ( ( ZONE_4_MASTER_VOLUME  .UshortValue)  ) ) 
            { 
            __context__.SourceCodeLine = 509;
            NVOLUME_SCALED = (short) ( ((ZONE_4_MASTER_VOLUME  .ShortValue * 100) / 32768) ) ; 
            __context__.SourceCodeLine = 510;
            Trace( "nVolume_Scaled: {0:d}\r\n", (uint)NVOLUME_SCALED) ; 
            __context__.SourceCodeLine = 512;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NVOLUME_SCALED >= 90 ))  ) ) 
                {
                __context__.SourceCodeLine = 513;
                MakeString ( DENON_TX__DOLLAR__ , "@0PXOT4LV{0}.0\u000D", Functions.LtoA (  (int) ( (NVOLUME_SCALED - 90) ) ) ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 514;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (NVOLUME_SCALED == 0))  ) ) 
                    {
                    __context__.SourceCodeLine = 515;
                    MakeString ( DENON_TX__DOLLAR__ , "@0PXOT4LVInf\u000D") ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 517;
                    MakeString ( DENON_TX__DOLLAR__ , "@0PXOT4LV-{0}.0\u000D", Functions.LtoA (  (int) ( (90 - NVOLUME_SCALED) ) ) ) ; 
                    }
                
                }
            
            __context__.SourceCodeLine = 519;
            MakeString ( DENON_TX__DOLLAR__ , "@0?PXOT4LV<CR>\u000D") ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ZONE_5_MASTER_VOLUME_OnChange_28 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 525;
        if ( Functions.TestForTrue  ( ( ZONE_5_MASTER_VOLUME  .UshortValue)  ) ) 
            { 
            __context__.SourceCodeLine = 527;
            NVOLUME_SCALED = (short) ( ((ZONE_5_MASTER_VOLUME  .ShortValue * 100) / 32768) ) ; 
            __context__.SourceCodeLine = 528;
            Trace( "nVolume_Scaled: {0:d}\r\n", (uint)NVOLUME_SCALED) ; 
            __context__.SourceCodeLine = 530;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NVOLUME_SCALED >= 90 ))  ) ) 
                {
                __context__.SourceCodeLine = 531;
                MakeString ( DENON_TX__DOLLAR__ , "@0PXOT5LV{0}.0\u000D", Functions.LtoA (  (int) ( (NVOLUME_SCALED - 90) ) ) ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 532;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (NVOLUME_SCALED == 0))  ) ) 
                    {
                    __context__.SourceCodeLine = 533;
                    MakeString ( DENON_TX__DOLLAR__ , "@0PXOT5LVInf\u000D") ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 535;
                    MakeString ( DENON_TX__DOLLAR__ , "@0PXOT5LV-{0}.0\u000D", Functions.LtoA (  (int) ( (90 - NVOLUME_SCALED) ) ) ) ; 
                    }
                
                }
            
            __context__.SourceCodeLine = 537;
            MakeString ( DENON_TX__DOLLAR__ , "@0?PXOT5LV<CR>\u000D") ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ZONE_6_MASTER_VOLUME_OnChange_29 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 543;
        if ( Functions.TestForTrue  ( ( ZONE_6_MASTER_VOLUME  .UshortValue)  ) ) 
            { 
            __context__.SourceCodeLine = 545;
            NVOLUME_SCALED = (short) ( ((ZONE_6_MASTER_VOLUME  .ShortValue * 100) / 32768) ) ; 
            __context__.SourceCodeLine = 546;
            Trace( "nVolume_Scaled: {0:d}\r\n", (uint)NVOLUME_SCALED) ; 
            __context__.SourceCodeLine = 548;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NVOLUME_SCALED >= 90 ))  ) ) 
                {
                __context__.SourceCodeLine = 549;
                MakeString ( DENON_TX__DOLLAR__ , "@0PXOT6LV{0}.0\u000D", Functions.LtoA (  (int) ( (NVOLUME_SCALED - 90) ) ) ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 550;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (NVOLUME_SCALED == 0))  ) ) 
                    {
                    __context__.SourceCodeLine = 551;
                    MakeString ( DENON_TX__DOLLAR__ , "@0PXOT6LVInf\u000D") ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 553;
                    MakeString ( DENON_TX__DOLLAR__ , "@0PXOT6LV-{0}.0\u000D", Functions.LtoA (  (int) ( (90 - NVOLUME_SCALED) ) ) ) ; 
                    }
                
                }
            
            __context__.SourceCodeLine = 555;
            MakeString ( DENON_TX__DOLLAR__ , "@0?PXOT6LV<CR>\u000D") ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ZONE_7_MASTER_VOLUME_OnChange_30 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 562;
        if ( Functions.TestForTrue  ( ( ZONE_7_MASTER_VOLUME  .UshortValue)  ) ) 
            { 
            __context__.SourceCodeLine = 564;
            NVOLUME_SCALED = (short) ( ((ZONE_7_MASTER_VOLUME  .ShortValue * 100) / 32768) ) ; 
            __context__.SourceCodeLine = 565;
            Trace( "nVolume_Scaled: {0:d}\r\n", (uint)NVOLUME_SCALED) ; 
            __context__.SourceCodeLine = 567;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NVOLUME_SCALED >= 90 ))  ) ) 
                {
                __context__.SourceCodeLine = 568;
                MakeString ( DENON_TX__DOLLAR__ , "@0PXOT7LV{0}.0\u000D", Functions.LtoA (  (int) ( (NVOLUME_SCALED - 90) ) ) ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 569;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (NVOLUME_SCALED == 0))  ) ) 
                    {
                    __context__.SourceCodeLine = 570;
                    MakeString ( DENON_TX__DOLLAR__ , "@0PXOT7LVInf\u000D") ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 572;
                    MakeString ( DENON_TX__DOLLAR__ , "@0PXOT7LV-{0}.0\u000D", Functions.LtoA (  (int) ( (90 - NVOLUME_SCALED) ) ) ) ; 
                    }
                
                }
            
            __context__.SourceCodeLine = 574;
            MakeString ( DENON_TX__DOLLAR__ , "@0?PXOT7LV<CR>\u000D") ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ZONE_8_MASTER_VOLUME_OnChange_31 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 580;
        if ( Functions.TestForTrue  ( ( ZONE_8_MASTER_VOLUME  .UshortValue)  ) ) 
            { 
            __context__.SourceCodeLine = 582;
            NVOLUME_SCALED = (short) ( ((ZONE_8_MASTER_VOLUME  .ShortValue * 100) / 32768) ) ; 
            __context__.SourceCodeLine = 583;
            Trace( "nVolume_Scaled: {0:d}\r\n", (uint)NVOLUME_SCALED) ; 
            __context__.SourceCodeLine = 585;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NVOLUME_SCALED >= 90 ))  ) ) 
                {
                __context__.SourceCodeLine = 586;
                MakeString ( DENON_TX__DOLLAR__ , "@0PXOT8LV{0}.0\u000D", Functions.LtoA (  (int) ( (NVOLUME_SCALED - 90) ) ) ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 587;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (NVOLUME_SCALED == 0))  ) ) 
                    {
                    __context__.SourceCodeLine = 588;
                    MakeString ( DENON_TX__DOLLAR__ , "@0PXOT8LVInf\u000D") ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 590;
                    MakeString ( DENON_TX__DOLLAR__ , "@0PXOT8LV-{0}.0\u000D", Functions.LtoA (  (int) ( (90 - NVOLUME_SCALED) ) ) ) ; 
                    }
                
                }
            
            __context__.SourceCodeLine = 592;
            MakeString ( DENON_TX__DOLLAR__ , "@0?PXOT8LV<CR>\u000D") ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}


public override void LogosSplusInitialize()
{
    SocketInfo __socketinfo__ = new SocketInfo( 1, this );
    InitialParametersClass.ResolveHostName = __socketinfo__.ResolveHostName;
    _SplusNVRAM = new SplusNVRAM( this );
    SERIALCOMMAND  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 64, this );
    
    POLL_ALL = new Crestron.Logos.SplusObjects.DigitalInput( POLL_ALL__DigitalInput__, this );
    m_DigitalInputList.Add( POLL_ALL__DigitalInput__, POLL_ALL );
    
    ZONE_1_SOURCE = new Crestron.Logos.SplusObjects.AnalogInput( ZONE_1_SOURCE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ZONE_1_SOURCE__AnalogSerialInput__, ZONE_1_SOURCE );
    
    ZONE_2_SOURCE = new Crestron.Logos.SplusObjects.AnalogInput( ZONE_2_SOURCE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ZONE_2_SOURCE__AnalogSerialInput__, ZONE_2_SOURCE );
    
    ZONE_3_SOURCE = new Crestron.Logos.SplusObjects.AnalogInput( ZONE_3_SOURCE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ZONE_3_SOURCE__AnalogSerialInput__, ZONE_3_SOURCE );
    
    ZONE_4_SOURCE = new Crestron.Logos.SplusObjects.AnalogInput( ZONE_4_SOURCE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ZONE_4_SOURCE__AnalogSerialInput__, ZONE_4_SOURCE );
    
    ZONE_5_SOURCE = new Crestron.Logos.SplusObjects.AnalogInput( ZONE_5_SOURCE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ZONE_5_SOURCE__AnalogSerialInput__, ZONE_5_SOURCE );
    
    ZONE_6_SOURCE = new Crestron.Logos.SplusObjects.AnalogInput( ZONE_6_SOURCE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ZONE_6_SOURCE__AnalogSerialInput__, ZONE_6_SOURCE );
    
    ZONE_7_SOURCE = new Crestron.Logos.SplusObjects.AnalogInput( ZONE_7_SOURCE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ZONE_7_SOURCE__AnalogSerialInput__, ZONE_7_SOURCE );
    
    ZONE_8_SOURCE = new Crestron.Logos.SplusObjects.AnalogInput( ZONE_8_SOURCE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ZONE_8_SOURCE__AnalogSerialInput__, ZONE_8_SOURCE );
    
    ZONE_1_SOURCE_VOLUME = new Crestron.Logos.SplusObjects.AnalogInput( ZONE_1_SOURCE_VOLUME__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ZONE_1_SOURCE_VOLUME__AnalogSerialInput__, ZONE_1_SOURCE_VOLUME );
    
    ZONE_2_SOURCE_VOLUME = new Crestron.Logos.SplusObjects.AnalogInput( ZONE_2_SOURCE_VOLUME__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ZONE_2_SOURCE_VOLUME__AnalogSerialInput__, ZONE_2_SOURCE_VOLUME );
    
    ZONE_3_SOURCE_VOLUME = new Crestron.Logos.SplusObjects.AnalogInput( ZONE_3_SOURCE_VOLUME__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ZONE_3_SOURCE_VOLUME__AnalogSerialInput__, ZONE_3_SOURCE_VOLUME );
    
    ZONE_4_SOURCE_VOLUME = new Crestron.Logos.SplusObjects.AnalogInput( ZONE_4_SOURCE_VOLUME__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ZONE_4_SOURCE_VOLUME__AnalogSerialInput__, ZONE_4_SOURCE_VOLUME );
    
    ZONE_5_SOURCE_VOLUME = new Crestron.Logos.SplusObjects.AnalogInput( ZONE_5_SOURCE_VOLUME__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ZONE_5_SOURCE_VOLUME__AnalogSerialInput__, ZONE_5_SOURCE_VOLUME );
    
    ZONE_6_SOURCE_VOLUME = new Crestron.Logos.SplusObjects.AnalogInput( ZONE_6_SOURCE_VOLUME__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ZONE_6_SOURCE_VOLUME__AnalogSerialInput__, ZONE_6_SOURCE_VOLUME );
    
    ZONE_7_SOURCE_VOLUME = new Crestron.Logos.SplusObjects.AnalogInput( ZONE_7_SOURCE_VOLUME__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ZONE_7_SOURCE_VOLUME__AnalogSerialInput__, ZONE_7_SOURCE_VOLUME );
    
    ZONE_8_SOURCE_VOLUME = new Crestron.Logos.SplusObjects.AnalogInput( ZONE_8_SOURCE_VOLUME__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ZONE_8_SOURCE_VOLUME__AnalogSerialInput__, ZONE_8_SOURCE_VOLUME );
    
    ZONE_1_MICLINE_VOLUME = new Crestron.Logos.SplusObjects.AnalogInput( ZONE_1_MICLINE_VOLUME__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ZONE_1_MICLINE_VOLUME__AnalogSerialInput__, ZONE_1_MICLINE_VOLUME );
    
    ZONE_2_MICLINE_VOLUME = new Crestron.Logos.SplusObjects.AnalogInput( ZONE_2_MICLINE_VOLUME__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ZONE_2_MICLINE_VOLUME__AnalogSerialInput__, ZONE_2_MICLINE_VOLUME );
    
    ZONE_3_MICLINE_VOLUME = new Crestron.Logos.SplusObjects.AnalogInput( ZONE_3_MICLINE_VOLUME__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ZONE_3_MICLINE_VOLUME__AnalogSerialInput__, ZONE_3_MICLINE_VOLUME );
    
    ZONE_4_MICLINE_VOLUME = new Crestron.Logos.SplusObjects.AnalogInput( ZONE_4_MICLINE_VOLUME__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ZONE_4_MICLINE_VOLUME__AnalogSerialInput__, ZONE_4_MICLINE_VOLUME );
    
    ZONE_5_MICLINE_VOLUME = new Crestron.Logos.SplusObjects.AnalogInput( ZONE_5_MICLINE_VOLUME__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ZONE_5_MICLINE_VOLUME__AnalogSerialInput__, ZONE_5_MICLINE_VOLUME );
    
    ZONE_6_MICLINE_VOLUME = new Crestron.Logos.SplusObjects.AnalogInput( ZONE_6_MICLINE_VOLUME__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ZONE_6_MICLINE_VOLUME__AnalogSerialInput__, ZONE_6_MICLINE_VOLUME );
    
    ZONE_7_MICLINE_VOLUME = new Crestron.Logos.SplusObjects.AnalogInput( ZONE_7_MICLINE_VOLUME__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ZONE_7_MICLINE_VOLUME__AnalogSerialInput__, ZONE_7_MICLINE_VOLUME );
    
    ZONE_8_MICLINE_VOLUME = new Crestron.Logos.SplusObjects.AnalogInput( ZONE_8_MICLINE_VOLUME__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ZONE_8_MICLINE_VOLUME__AnalogSerialInput__, ZONE_8_MICLINE_VOLUME );
    
    ZONE_1_MASTER_VOLUME = new Crestron.Logos.SplusObjects.AnalogInput( ZONE_1_MASTER_VOLUME__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ZONE_1_MASTER_VOLUME__AnalogSerialInput__, ZONE_1_MASTER_VOLUME );
    
    ZONE_2_MASTER_VOLUME = new Crestron.Logos.SplusObjects.AnalogInput( ZONE_2_MASTER_VOLUME__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ZONE_2_MASTER_VOLUME__AnalogSerialInput__, ZONE_2_MASTER_VOLUME );
    
    ZONE_3_MASTER_VOLUME = new Crestron.Logos.SplusObjects.AnalogInput( ZONE_3_MASTER_VOLUME__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ZONE_3_MASTER_VOLUME__AnalogSerialInput__, ZONE_3_MASTER_VOLUME );
    
    ZONE_4_MASTER_VOLUME = new Crestron.Logos.SplusObjects.AnalogInput( ZONE_4_MASTER_VOLUME__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ZONE_4_MASTER_VOLUME__AnalogSerialInput__, ZONE_4_MASTER_VOLUME );
    
    ZONE_5_MASTER_VOLUME = new Crestron.Logos.SplusObjects.AnalogInput( ZONE_5_MASTER_VOLUME__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ZONE_5_MASTER_VOLUME__AnalogSerialInput__, ZONE_5_MASTER_VOLUME );
    
    ZONE_6_MASTER_VOLUME = new Crestron.Logos.SplusObjects.AnalogInput( ZONE_6_MASTER_VOLUME__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ZONE_6_MASTER_VOLUME__AnalogSerialInput__, ZONE_6_MASTER_VOLUME );
    
    ZONE_7_MASTER_VOLUME = new Crestron.Logos.SplusObjects.AnalogInput( ZONE_7_MASTER_VOLUME__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ZONE_7_MASTER_VOLUME__AnalogSerialInput__, ZONE_7_MASTER_VOLUME );
    
    ZONE_8_MASTER_VOLUME = new Crestron.Logos.SplusObjects.AnalogInput( ZONE_8_MASTER_VOLUME__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ZONE_8_MASTER_VOLUME__AnalogSerialInput__, ZONE_8_MASTER_VOLUME );
    
    ZONE_1_MASTER_MUTE = new Crestron.Logos.SplusObjects.AnalogInput( ZONE_1_MASTER_MUTE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ZONE_1_MASTER_MUTE__AnalogSerialInput__, ZONE_1_MASTER_MUTE );
    
    ZONE_2_MASTER_MUTE = new Crestron.Logos.SplusObjects.AnalogInput( ZONE_2_MASTER_MUTE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ZONE_2_MASTER_MUTE__AnalogSerialInput__, ZONE_2_MASTER_MUTE );
    
    ZONE_3_MASTER_MUTE = new Crestron.Logos.SplusObjects.AnalogInput( ZONE_3_MASTER_MUTE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ZONE_3_MASTER_MUTE__AnalogSerialInput__, ZONE_3_MASTER_MUTE );
    
    ZONE_4_MASTER_MUTE = new Crestron.Logos.SplusObjects.AnalogInput( ZONE_4_MASTER_MUTE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ZONE_4_MASTER_MUTE__AnalogSerialInput__, ZONE_4_MASTER_MUTE );
    
    ZONE_5_MASTER_MUTE = new Crestron.Logos.SplusObjects.AnalogInput( ZONE_5_MASTER_MUTE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ZONE_5_MASTER_MUTE__AnalogSerialInput__, ZONE_5_MASTER_MUTE );
    
    ZONE_6_MASTER_MUTE = new Crestron.Logos.SplusObjects.AnalogInput( ZONE_6_MASTER_MUTE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ZONE_6_MASTER_MUTE__AnalogSerialInput__, ZONE_6_MASTER_MUTE );
    
    ZONE_7_MASTER_MUTE = new Crestron.Logos.SplusObjects.AnalogInput( ZONE_7_MASTER_MUTE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ZONE_7_MASTER_MUTE__AnalogSerialInput__, ZONE_7_MASTER_MUTE );
    
    ZONE_8_MASTER_MUTE = new Crestron.Logos.SplusObjects.AnalogInput( ZONE_8_MASTER_MUTE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ZONE_8_MASTER_MUTE__AnalogSerialInput__, ZONE_8_MASTER_MUTE );
    
    DENON_RX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( DENON_RX__DOLLAR____AnalogSerialInput__, 256, this );
    m_StringInputList.Add( DENON_RX__DOLLAR____AnalogSerialInput__, DENON_RX__DOLLAR__ );
    
    DENON_TX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DENON_TX__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DENON_TX__DOLLAR____AnalogSerialOutput__, DENON_TX__DOLLAR__ );
    
    
    ZONE_1_SOURCE.OnAnalogChange.Add( new InputChangeHandlerWrapper( ZONE_1_SOURCE_OnChange_0, false ) );
    ZONE_2_SOURCE.OnAnalogChange.Add( new InputChangeHandlerWrapper( ZONE_2_SOURCE_OnChange_1, false ) );
    ZONE_3_SOURCE.OnAnalogChange.Add( new InputChangeHandlerWrapper( ZONE_3_SOURCE_OnChange_2, false ) );
    ZONE_4_SOURCE.OnAnalogChange.Add( new InputChangeHandlerWrapper( ZONE_4_SOURCE_OnChange_3, false ) );
    ZONE_5_SOURCE.OnAnalogChange.Add( new InputChangeHandlerWrapper( ZONE_5_SOURCE_OnChange_4, false ) );
    ZONE_6_SOURCE.OnAnalogChange.Add( new InputChangeHandlerWrapper( ZONE_6_SOURCE_OnChange_5, false ) );
    ZONE_7_SOURCE.OnAnalogChange.Add( new InputChangeHandlerWrapper( ZONE_7_SOURCE_OnChange_6, false ) );
    ZONE_8_SOURCE.OnAnalogChange.Add( new InputChangeHandlerWrapper( ZONE_8_SOURCE_OnChange_7, false ) );
    ZONE_1_SOURCE_VOLUME.OnAnalogChange.Add( new InputChangeHandlerWrapper( ZONE_1_SOURCE_VOLUME_OnChange_8, false ) );
    ZONE_2_SOURCE_VOLUME.OnAnalogChange.Add( new InputChangeHandlerWrapper( ZONE_2_SOURCE_VOLUME_OnChange_9, false ) );
    ZONE_3_SOURCE_VOLUME.OnAnalogChange.Add( new InputChangeHandlerWrapper( ZONE_3_SOURCE_VOLUME_OnChange_10, false ) );
    ZONE_4_SOURCE_VOLUME.OnAnalogChange.Add( new InputChangeHandlerWrapper( ZONE_4_SOURCE_VOLUME_OnChange_11, false ) );
    ZONE_5_SOURCE_VOLUME.OnAnalogChange.Add( new InputChangeHandlerWrapper( ZONE_5_SOURCE_VOLUME_OnChange_12, false ) );
    ZONE_6_SOURCE_VOLUME.OnAnalogChange.Add( new InputChangeHandlerWrapper( ZONE_6_SOURCE_VOLUME_OnChange_13, false ) );
    ZONE_7_SOURCE_VOLUME.OnAnalogChange.Add( new InputChangeHandlerWrapper( ZONE_7_SOURCE_VOLUME_OnChange_14, false ) );
    ZONE_8_SOURCE_VOLUME.OnAnalogChange.Add( new InputChangeHandlerWrapper( ZONE_8_SOURCE_VOLUME_OnChange_15, false ) );
    ZONE_1_MICLINE_VOLUME.OnAnalogChange.Add( new InputChangeHandlerWrapper( ZONE_1_MICLINE_VOLUME_OnChange_16, false ) );
    ZONE_2_MICLINE_VOLUME.OnAnalogChange.Add( new InputChangeHandlerWrapper( ZONE_2_MICLINE_VOLUME_OnChange_17, false ) );
    ZONE_3_MICLINE_VOLUME.OnAnalogChange.Add( new InputChangeHandlerWrapper( ZONE_3_MICLINE_VOLUME_OnChange_18, false ) );
    ZONE_4_MICLINE_VOLUME.OnAnalogChange.Add( new InputChangeHandlerWrapper( ZONE_4_MICLINE_VOLUME_OnChange_19, false ) );
    ZONE_5_MICLINE_VOLUME.OnAnalogChange.Add( new InputChangeHandlerWrapper( ZONE_5_MICLINE_VOLUME_OnChange_20, false ) );
    ZONE_6_MICLINE_VOLUME.OnAnalogChange.Add( new InputChangeHandlerWrapper( ZONE_6_MICLINE_VOLUME_OnChange_21, false ) );
    ZONE_7_MICLINE_VOLUME.OnAnalogChange.Add( new InputChangeHandlerWrapper( ZONE_7_MICLINE_VOLUME_OnChange_22, false ) );
    ZONE_8_MICLINE_VOLUME.OnAnalogChange.Add( new InputChangeHandlerWrapper( ZONE_8_MICLINE_VOLUME_OnChange_23, false ) );
    ZONE_1_MASTER_VOLUME.OnAnalogChange.Add( new InputChangeHandlerWrapper( ZONE_1_MASTER_VOLUME_OnChange_24, false ) );
    ZONE_2_MASTER_VOLUME.OnAnalogChange.Add( new InputChangeHandlerWrapper( ZONE_2_MASTER_VOLUME_OnChange_25, false ) );
    ZONE_3_MASTER_VOLUME.OnAnalogChange.Add( new InputChangeHandlerWrapper( ZONE_3_MASTER_VOLUME_OnChange_26, false ) );
    ZONE_4_MASTER_VOLUME.OnAnalogChange.Add( new InputChangeHandlerWrapper( ZONE_4_MASTER_VOLUME_OnChange_27, false ) );
    ZONE_5_MASTER_VOLUME.OnAnalogChange.Add( new InputChangeHandlerWrapper( ZONE_5_MASTER_VOLUME_OnChange_28, false ) );
    ZONE_6_MASTER_VOLUME.OnAnalogChange.Add( new InputChangeHandlerWrapper( ZONE_6_MASTER_VOLUME_OnChange_29, false ) );
    ZONE_7_MASTER_VOLUME.OnAnalogChange.Add( new InputChangeHandlerWrapper( ZONE_7_MASTER_VOLUME_OnChange_30, false ) );
    ZONE_8_MASTER_VOLUME.OnAnalogChange.Add( new InputChangeHandlerWrapper( ZONE_8_MASTER_VOLUME_OnChange_31, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_DENON_DN_508MXA ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint POLL_ALL__DigitalInput__ = 0;
const uint ZONE_1_SOURCE__AnalogSerialInput__ = 0;
const uint ZONE_2_SOURCE__AnalogSerialInput__ = 1;
const uint ZONE_3_SOURCE__AnalogSerialInput__ = 2;
const uint ZONE_4_SOURCE__AnalogSerialInput__ = 3;
const uint ZONE_5_SOURCE__AnalogSerialInput__ = 4;
const uint ZONE_6_SOURCE__AnalogSerialInput__ = 5;
const uint ZONE_7_SOURCE__AnalogSerialInput__ = 6;
const uint ZONE_8_SOURCE__AnalogSerialInput__ = 7;
const uint ZONE_1_SOURCE_VOLUME__AnalogSerialInput__ = 8;
const uint ZONE_2_SOURCE_VOLUME__AnalogSerialInput__ = 9;
const uint ZONE_3_SOURCE_VOLUME__AnalogSerialInput__ = 10;
const uint ZONE_4_SOURCE_VOLUME__AnalogSerialInput__ = 11;
const uint ZONE_5_SOURCE_VOLUME__AnalogSerialInput__ = 12;
const uint ZONE_6_SOURCE_VOLUME__AnalogSerialInput__ = 13;
const uint ZONE_7_SOURCE_VOLUME__AnalogSerialInput__ = 14;
const uint ZONE_8_SOURCE_VOLUME__AnalogSerialInput__ = 15;
const uint ZONE_1_MICLINE_VOLUME__AnalogSerialInput__ = 16;
const uint ZONE_2_MICLINE_VOLUME__AnalogSerialInput__ = 17;
const uint ZONE_3_MICLINE_VOLUME__AnalogSerialInput__ = 18;
const uint ZONE_4_MICLINE_VOLUME__AnalogSerialInput__ = 19;
const uint ZONE_5_MICLINE_VOLUME__AnalogSerialInput__ = 20;
const uint ZONE_6_MICLINE_VOLUME__AnalogSerialInput__ = 21;
const uint ZONE_7_MICLINE_VOLUME__AnalogSerialInput__ = 22;
const uint ZONE_8_MICLINE_VOLUME__AnalogSerialInput__ = 23;
const uint ZONE_1_MASTER_VOLUME__AnalogSerialInput__ = 24;
const uint ZONE_2_MASTER_VOLUME__AnalogSerialInput__ = 25;
const uint ZONE_3_MASTER_VOLUME__AnalogSerialInput__ = 26;
const uint ZONE_4_MASTER_VOLUME__AnalogSerialInput__ = 27;
const uint ZONE_5_MASTER_VOLUME__AnalogSerialInput__ = 28;
const uint ZONE_6_MASTER_VOLUME__AnalogSerialInput__ = 29;
const uint ZONE_7_MASTER_VOLUME__AnalogSerialInput__ = 30;
const uint ZONE_8_MASTER_VOLUME__AnalogSerialInput__ = 31;
const uint ZONE_1_MASTER_MUTE__AnalogSerialInput__ = 32;
const uint ZONE_2_MASTER_MUTE__AnalogSerialInput__ = 33;
const uint ZONE_3_MASTER_MUTE__AnalogSerialInput__ = 34;
const uint ZONE_4_MASTER_MUTE__AnalogSerialInput__ = 35;
const uint ZONE_5_MASTER_MUTE__AnalogSerialInput__ = 36;
const uint ZONE_6_MASTER_MUTE__AnalogSerialInput__ = 37;
const uint ZONE_7_MASTER_MUTE__AnalogSerialInput__ = 38;
const uint ZONE_8_MASTER_MUTE__AnalogSerialInput__ = 39;
const uint DENON_RX__DOLLAR____AnalogSerialInput__ = 40;
const uint DENON_TX__DOLLAR____AnalogSerialOutput__ = 0;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    
}

SplusNVRAM _SplusNVRAM = null;

public class __CEvent__ : CEvent
{
    public __CEvent__() {}
    public void Close() { base.Close(); }
    public int Reset() { return base.Reset() ? 1 : 0; }
    public int Set() { return base.Set() ? 1 : 0; }
    public int Wait( int timeOutInMs ) { return base.Wait( timeOutInMs ) ? 1 : 0; }
}
public class __CMutex__ : CMutex
{
    public __CMutex__() {}
    public void Close() { base.Close(); }
    public void ReleaseMutex() { base.ReleaseMutex(); }
    public int WaitForMutex() { return base.WaitForMutex() ? 1 : 0; }
}
 public int IsNull( object obj ){ return (obj == null) ? 1 : 0; }
}


}
