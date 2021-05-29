using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace DiCon
{
    public class Gp600
    {
        public sealed class Commands
        {
            public sealed class Common
            {
                public static readonly string Identification = "*IDN?";
                public static readonly string Reset = "RESET";
                public static readonly string Configuration = "SYST:CONF?";
                public static readonly string ErrorStatus = "SYSTEM:ERROR?";
                public static readonly string FirmwareVersion = "VERSION?";
            }

            public class Attenuation
            {
                public string AttenuationSet(uint device, float value) => $"A{device} Attenuation {value}";
                public string AttenuationGet(uint device) => $"A{device} Attenuation?";
                public string AttenuationDecrement(uint device, float value) => $"A{device} Decrement {value}";
                public string AttenuationIncrement(uint device, float value) => $"A{device} Increment {value}";
                public string AttenuationMaximumGet(uint device) => $"A{device} MAXIMUM?";
                public string AttenuationWavelengthSet(uint device, float value) => $"A{device} Wavelength {value}";
                public string AttenuationWavelengthGet(uint device) => $"A{device} Wavelength?";
                public string AttenuationWavelengthAvailableGet(uint device) => @$"A{device} WAVElengthSAVAILable?";
            }

            public class Module
            {
                public string TapDetectorsGet(uint device) => $"D{device}?";
            }

            public class Dpe
            {
                public string AttenuationSet(uint device, float value) => $"E{device} Attenuation {value}";
                public string AttenuationGet(uint device) => $"E{device} Attenuation?";

                public string AttenuationDecrement(uint device, float value) =>
                    @$"E{device} DECrementAttenuation {value}";

                public string AttenuationIncrement(uint device, float value) =>
                    @$"E{device} INCrementAttenuation {value}";

                public string PowerDecrement(uint device, float value) => @$"E{device} DECrementPower {value}";
                public string PowerIncrement(uint device, float value) => @$"E{device} INCrementPower {value}";
                public string AttenuationMaximumGet(uint device) => @$"E{device} MAXimumAttenuation?";
                public string PowerMaximumGet(uint device) => @$"E{device} MAXimumPower?";
                public string PowerMinimumGet(uint device) => @$"E{device} MINimumPower?";
                public string PowerTargetSet(uint device, float value) => $"E{device} Power {value}";
                public string PowerTargetGet(uint device) => $"E{device} Power?";
                public string PowerControlLoopGet(uint device) => $"E{device} STATus?";
                public string TapDetectorPowerOffsetSet(uint device, float value) => @$"E{device} TOFFset {value}";
                public string TapDetectorPowerOffsetGet(uint device) => @$"E{device} TOFFset?";
                public string TogglePowerControlLoopSet(uint device) => @$"E{device} TOGgle";
                public string WavelengthSet(uint device, float value) => $"E{device} Wavelength {value}";
                public string WavelengthGet(uint device) => $"E{device} Wavelength?";
                public string WavelengthAvailableGet(uint device) => @$"E{device} WAVElengthSAVAILable?";
            }

            public class Switch
            {
                public class OneXn
                {
                    public string PathSet(uint device, uint outputChannel) => @$"M{device} CHannel {outputChannel}";
                    public string PathGet(uint device) => @$"M{device} CHannel?";
                    public string Increment(uint device, uint step = 1) => @$"M{device} INCrement {step}";
                    public string Decrement(uint device, uint step = 1) => @$"M{device} DECrement {step}";
                    public string DimensionGet(uint device) => @$"M{device} DIMensions?";
                }

                public class Mxn
                {
                    public string PathSet(uint device, uint inputChannel, uint outputChannel) =>
                        @$"M{device} CHannel {inputChannel} {outputChannel}";

                    public string PathGet(uint device, uint inputChannel) => @$"M{device} CHannel {inputChannel}?";

                    public string Increment(uint device, uint inputChannel, uint step = 1) =>
                        @$"M{device} INCrement {inputChannel} {step}";

                    public string Decrement(uint device, uint inputChannel, uint step = 1) =>
                        @$"M{device} DECrement {inputChannel} {step}";

                    public string DimensionGet(uint device) => @$"M{device} DIMensions?";
                }

                public class MultiStateSwitch
                {
                    public string MaximumStateGet(uint device) => @$"S{device} MAXimum?";
                    public string MinimumStateGet(uint device) => @$"S{device} MINimum?";
                    public string StateSet(uint device, uint state) => $"S{device} State {state}";
                    public string StateGet(uint device) => $"S{device} State?";
                    public string StateToggle(uint device) => @$"S{device} TOGgle";
                }

                public class TapDetector
                {
                    public string PowerMaximumGet(uint device) => @$"T{device} MAXimumPower?";
                    public string PowerMinimumGet(uint device) => @$"T{device} MINimumPower?";
                    public string PowerOffsetSet(uint device, uint offset) => @$"T{device} OFFset {offset}";
                    public string PowerOffsetGet(uint device) => @$"T{device} OFFset?";
                    public string PowerRead(uint device) => $"T{device} Read?";
                    public string WavelengthSet(uint device, float value) => $"T{device} Wavelength {value}";
                    public string WavelengthGet(uint device) => $"T{device} Wavelength?";
                    public string WavelengthAvailableGet(uint device) => @$"T{device} WAVElengthSAVAILable?";
                }

                public class Matrix3DMxN
                {
                    public string PathSet(uint device, uint inputChannel, uint outputChannel) =>
                        @$"X{device} CHannel {inputChannel} {outputChannel}";

                    public string PathGet(uint device, uint inputChannel) => @$"X{device} CHannel {inputChannel}?";
                    public string DimensionGet(uint device) => @$"X{device} DIMensions?";

                    public string Increment(uint device, uint inputChannel, uint step = 1) =>
                        @$"X{device} INCrement {inputChannel} {step}";

                    public string Decrement(uint device, uint inputChannel, uint step = 1) =>
                        @$"X{device} DECrement {inputChannel} {step}";

                    public string WavelengthSet(uint device, float value) => $"X{device} Wavelength {value}";
                    public string WavelengthGet(uint device) => $"X{device} Wavelength?";
                    public string WavelengthAvailableGet(uint device) => @$"X{device} WAVElengthSAVAILable?";
                }
            }
        }

        public static class ErrorCodes
        {
            private static readonly Dictionary<uint, string> Dictionary = new Dictionary<uint, string>
            {
                {0, "No Error"},
                {109, "Missing parameter"},
                {112, "Channel fail, motor move fail, switch busy, Cmd queue near full, Cmd queue overflow"},
                {113, "Unrecognized command"},
                {222, "Parameter out of range"},
                {223, "Parameter too large"},
                {224, "Illegal parameter value"},
                {403, "Communications error, Attenuator communications error, Filter communications error," +
                      " Switch communications error, Motor communications error, Tap communications error, Prism communications error"},
                {604, "Communications error"}
            };

            public static string ErrorMessage(uint errorCode) => Dictionary != null && Dictionary.TryGetValue(errorCode, out var result) ? result : null;
        }
    }
}
