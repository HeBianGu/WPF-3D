using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkX3DExporter
	/// </summary>
	/// <remarks>
	///    create an x3d file
	///
	/// vtkX3DExporter is a render window exporter which writes out the rendered
	/// scene into an X3D file. X3D is an XML-based format for representation
	/// 3D scenes (similar to VRML). Check out http://www.web3d.org/x3d/ for more
	/// details.
	/// @par Thanks:
	/// X3DExporter is contributed by Christophe Mouton at EDF.
	/// </remarks>
	// Token: 0x020001F6 RID: 502
	public class vtkX3DExporter : vtkExporter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060060AA RID: 24746 RVA: 0x0008B3B7 File Offset: 0x000895B7
		static vtkX3DExporter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkX3DExporter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkX3DExporter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060060AB RID: 24747 RVA: 0x0008B3DF File Offset: 0x000895DF
		public vtkX3DExporter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060060AC RID: 24748
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkX3DExporter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060060AD RID: 24749 RVA: 0x0008B3F0 File Offset: 0x000895F0
		public new static vtkX3DExporter New()
		{
			vtkX3DExporter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkX3DExporter.vtkX3DExporter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkX3DExporter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060060AE RID: 24750 RVA: 0x0008B444 File Offset: 0x00089644
		public vtkX3DExporter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkX3DExporter.vtkX3DExporter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060060AF RID: 24751 RVA: 0x0008B488 File Offset: 0x00089688
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060060B0 RID: 24752
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkX3DExporter_BinaryOff_01(HandleRef pThis);

		/// <summary>
		/// Turn on binary mode
		/// </summary>
		// Token: 0x060060B1 RID: 24753 RVA: 0x0008B493 File Offset: 0x00089693
		public virtual void BinaryOff()
		{
			vtkX3DExporter.vtkX3DExporter_BinaryOff_01(base.GetCppThis());
		}

		// Token: 0x060060B2 RID: 24754
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkX3DExporter_BinaryOn_02(HandleRef pThis);

		/// <summary>
		/// Turn on binary mode
		/// </summary>
		// Token: 0x060060B3 RID: 24755 RVA: 0x0008B4A2 File Offset: 0x000896A2
		public virtual void BinaryOn()
		{
			vtkX3DExporter.vtkX3DExporter_BinaryOn_02(base.GetCppThis());
		}

		// Token: 0x060060B4 RID: 24756
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkX3DExporter_FastestOff_03(HandleRef pThis);

		/// <summary>
		/// In binary mode use fastest instead of best compression
		/// </summary>
		// Token: 0x060060B5 RID: 24757 RVA: 0x0008B4B1 File Offset: 0x000896B1
		public virtual void FastestOff()
		{
			vtkX3DExporter.vtkX3DExporter_FastestOff_03(base.GetCppThis());
		}

		// Token: 0x060060B6 RID: 24758
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkX3DExporter_FastestOn_04(HandleRef pThis);

		/// <summary>
		/// In binary mode use fastest instead of best compression
		/// </summary>
		// Token: 0x060060B7 RID: 24759 RVA: 0x0008B4C0 File Offset: 0x000896C0
		public virtual void FastestOn()
		{
			vtkX3DExporter.vtkX3DExporter_FastestOn_04(base.GetCppThis());
		}

		// Token: 0x060060B8 RID: 24760
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkX3DExporter_GetBinary_05(HandleRef pThis);

		/// <summary>
		/// Turn on binary mode
		/// </summary>
		// Token: 0x060060B9 RID: 24761 RVA: 0x0008B4D0 File Offset: 0x000896D0
		public virtual int GetBinary()
		{
			return vtkX3DExporter.vtkX3DExporter_GetBinary_05(base.GetCppThis());
		}

		// Token: 0x060060BA RID: 24762
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkX3DExporter_GetBinaryMaxValue_06(HandleRef pThis);

		/// <summary>
		/// Turn on binary mode
		/// </summary>
		// Token: 0x060060BB RID: 24763 RVA: 0x0008B4F0 File Offset: 0x000896F0
		public virtual int GetBinaryMaxValue()
		{
			return vtkX3DExporter.vtkX3DExporter_GetBinaryMaxValue_06(base.GetCppThis());
		}

		// Token: 0x060060BC RID: 24764
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkX3DExporter_GetBinaryMinValue_07(HandleRef pThis);

		/// <summary>
		/// Turn on binary mode
		/// </summary>
		// Token: 0x060060BD RID: 24765 RVA: 0x0008B510 File Offset: 0x00089710
		public virtual int GetBinaryMinValue()
		{
			return vtkX3DExporter.vtkX3DExporter_GetBinaryMinValue_07(base.GetCppThis());
		}

		// Token: 0x060060BE RID: 24766
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkX3DExporter_GetBinaryOutputString_08(HandleRef pThis);

		/// <summary>
		/// When WriteToOutputString in on, then a string is allocated, written to,
		/// and can be retrieved with these methods.  The string is deleted during
		/// the next call to write ...
		/// </summary>
		// Token: 0x060060BF RID: 24767 RVA: 0x0008B530 File Offset: 0x00089730
		public IntPtr GetBinaryOutputString()
		{
			return vtkX3DExporter.vtkX3DExporter_GetBinaryOutputString_08(base.GetCppThis());
		}

		// Token: 0x060060C0 RID: 24768
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkX3DExporter_GetFastest_09(HandleRef pThis);

		/// <summary>
		/// In binary mode use fastest instead of best compression
		/// </summary>
		// Token: 0x060060C1 RID: 24769 RVA: 0x0008B550 File Offset: 0x00089750
		public virtual int GetFastest()
		{
			return vtkX3DExporter.vtkX3DExporter_GetFastest_09(base.GetCppThis());
		}

		// Token: 0x060060C2 RID: 24770
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkX3DExporter_GetFastestMaxValue_10(HandleRef pThis);

		/// <summary>
		/// In binary mode use fastest instead of best compression
		/// </summary>
		// Token: 0x060060C3 RID: 24771 RVA: 0x0008B570 File Offset: 0x00089770
		public virtual int GetFastestMaxValue()
		{
			return vtkX3DExporter.vtkX3DExporter_GetFastestMaxValue_10(base.GetCppThis());
		}

		// Token: 0x060060C4 RID: 24772
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkX3DExporter_GetFastestMinValue_11(HandleRef pThis);

		/// <summary>
		/// In binary mode use fastest instead of best compression
		/// </summary>
		// Token: 0x060060C5 RID: 24773 RVA: 0x0008B590 File Offset: 0x00089790
		public virtual int GetFastestMinValue()
		{
			return vtkX3DExporter.vtkX3DExporter_GetFastestMinValue_11(base.GetCppThis());
		}

		// Token: 0x060060C6 RID: 24774
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkX3DExporter_GetFileName_12(HandleRef pThis);

		/// <summary>
		/// Set/Get the output file name.
		/// </summary>
		// Token: 0x060060C7 RID: 24775 RVA: 0x0008B5B0 File Offset: 0x000897B0
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkX3DExporter.vtkX3DExporter_GetFileName_12(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060060C8 RID: 24776
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkX3DExporter_GetNumberOfGenerationsFromBase_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060060C9 RID: 24777 RVA: 0x0008B5EC File Offset: 0x000897EC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkX3DExporter.vtkX3DExporter_GetNumberOfGenerationsFromBase_13(base.GetCppThis(), type);
		}

		// Token: 0x060060CA RID: 24778
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkX3DExporter_GetNumberOfGenerationsFromBaseType_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060060CB RID: 24779 RVA: 0x0008B60C File Offset: 0x0008980C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkX3DExporter.vtkX3DExporter_GetNumberOfGenerationsFromBaseType_14(type);
		}

		// Token: 0x060060CC RID: 24780
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkX3DExporter_GetOutputString_15(HandleRef pThis);

		/// <summary>
		/// When WriteToOutputString in on, then a string is allocated, written to,
		/// and can be retrieved with these methods.  The string is deleted during
		/// the next call to write ...
		/// </summary>
		// Token: 0x060060CD RID: 24781 RVA: 0x0008B628 File Offset: 0x00089828
		public virtual string GetOutputString()
		{
			string s = Marshal.PtrToStringAnsi(vtkX3DExporter.vtkX3DExporter_GetOutputString_15(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060060CE RID: 24782
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkX3DExporter_GetOutputStringLength_16(HandleRef pThis);

		/// <summary>
		/// When WriteToOutputString in on, then a string is allocated, written to,
		/// and can be retrieved with these methods.  The string is deleted during
		/// the next call to write ...
		/// </summary>
		// Token: 0x060060CF RID: 24783 RVA: 0x0008B664 File Offset: 0x00089864
		public virtual long GetOutputStringLength()
		{
			return vtkX3DExporter.vtkX3DExporter_GetOutputStringLength_16(base.GetCppThis());
		}

		// Token: 0x060060D0 RID: 24784
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkX3DExporter_GetSpeed_17(HandleRef pThis);

		/// <summary>
		/// Specify the Speed of navigation. Default is 4.
		/// </summary>
		// Token: 0x060060D1 RID: 24785 RVA: 0x0008B684 File Offset: 0x00089884
		public virtual double GetSpeed()
		{
			return vtkX3DExporter.vtkX3DExporter_GetSpeed_17(base.GetCppThis());
		}

		// Token: 0x060060D2 RID: 24786
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkX3DExporter_GetWriteToOutputString_18(HandleRef pThis);

		/// <summary>
		/// Enable writing to an OutputString instead of the default, a file.
		/// </summary>
		// Token: 0x060060D3 RID: 24787 RVA: 0x0008B6A4 File Offset: 0x000898A4
		public virtual int GetWriteToOutputString()
		{
			return vtkX3DExporter.vtkX3DExporter_GetWriteToOutputString_18(base.GetCppThis());
		}

		// Token: 0x060060D4 RID: 24788
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkX3DExporter_IsA_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060060D5 RID: 24789 RVA: 0x0008B6C4 File Offset: 0x000898C4
		public override int IsA(string type)
		{
			return vtkX3DExporter.vtkX3DExporter_IsA_19(base.GetCppThis(), type);
		}

		// Token: 0x060060D6 RID: 24790
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkX3DExporter_IsTypeOf_20([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060060D7 RID: 24791 RVA: 0x0008B6E4 File Offset: 0x000898E4
		public new static int IsTypeOf(string type)
		{
			return vtkX3DExporter.vtkX3DExporter_IsTypeOf_20(type);
		}

		// Token: 0x060060D8 RID: 24792
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkX3DExporter_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060060D9 RID: 24793 RVA: 0x0008B700 File Offset: 0x00089900
		public new vtkX3DExporter NewInstance()
		{
			vtkX3DExporter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkX3DExporter.vtkX3DExporter_NewInstance_22(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkX3DExporter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060060DA RID: 24794
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkX3DExporter_RegisterAndGetOutputString_23(HandleRef pThis);

		/// <summary>
		/// This convenience method returns the string, sets the IVAR to nullptr,
		/// so that the user is responsible for deleting the string.
		/// I am not sure what the name should be, so it may change in the future.
		/// </summary>
		// Token: 0x060060DB RID: 24795 RVA: 0x0008B75C File Offset: 0x0008995C
		public string RegisterAndGetOutputString()
		{
			string s = Marshal.PtrToStringAnsi(vtkX3DExporter.vtkX3DExporter_RegisterAndGetOutputString_23(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060060DC RID: 24796
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkX3DExporter_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060060DD RID: 24797 RVA: 0x0008B798 File Offset: 0x00089998
		public new static vtkX3DExporter SafeDownCast(vtkObjectBase o)
		{
			vtkX3DExporter vtkX3DExporter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkX3DExporter.vtkX3DExporter_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkX3DExporter = (vtkX3DExporter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkX3DExporter.Register(null);
				}
			}
			return vtkX3DExporter;
		}

		// Token: 0x060060DE RID: 24798
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkX3DExporter_SetBinary_25(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on binary mode
		/// </summary>
		// Token: 0x060060DF RID: 24799 RVA: 0x0008B817 File Offset: 0x00089A17
		public virtual void SetBinary(int _arg)
		{
			vtkX3DExporter.vtkX3DExporter_SetBinary_25(base.GetCppThis(), _arg);
		}

		// Token: 0x060060E0 RID: 24800
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkX3DExporter_SetFastest_26(HandleRef pThis, int _arg);

		/// <summary>
		/// In binary mode use fastest instead of best compression
		/// </summary>
		// Token: 0x060060E1 RID: 24801 RVA: 0x0008B827 File Offset: 0x00089A27
		public virtual void SetFastest(int _arg)
		{
			vtkX3DExporter.vtkX3DExporter_SetFastest_26(base.GetCppThis(), _arg);
		}

		// Token: 0x060060E2 RID: 24802
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkX3DExporter_SetFileName_27(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the output file name.
		/// </summary>
		// Token: 0x060060E3 RID: 24803 RVA: 0x0008B837 File Offset: 0x00089A37
		public virtual void SetFileName(string _arg)
		{
			vtkX3DExporter.vtkX3DExporter_SetFileName_27(base.GetCppThis(), _arg);
		}

		// Token: 0x060060E4 RID: 24804
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkX3DExporter_SetSpeed_28(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the Speed of navigation. Default is 4.
		/// </summary>
		// Token: 0x060060E5 RID: 24805 RVA: 0x0008B847 File Offset: 0x00089A47
		public virtual void SetSpeed(double _arg)
		{
			vtkX3DExporter.vtkX3DExporter_SetSpeed_28(base.GetCppThis(), _arg);
		}

		// Token: 0x060060E6 RID: 24806
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkX3DExporter_SetWriteToOutputString_29(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable writing to an OutputString instead of the default, a file.
		/// </summary>
		// Token: 0x060060E7 RID: 24807 RVA: 0x0008B857 File Offset: 0x00089A57
		public virtual void SetWriteToOutputString(int _arg)
		{
			vtkX3DExporter.vtkX3DExporter_SetWriteToOutputString_29(base.GetCppThis(), _arg);
		}

		// Token: 0x060060E8 RID: 24808
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkX3DExporter_WriteToOutputStringOff_30(HandleRef pThis);

		/// <summary>
		/// Enable writing to an OutputString instead of the default, a file.
		/// </summary>
		// Token: 0x060060E9 RID: 24809 RVA: 0x0008B867 File Offset: 0x00089A67
		public virtual void WriteToOutputStringOff()
		{
			vtkX3DExporter.vtkX3DExporter_WriteToOutputStringOff_30(base.GetCppThis());
		}

		// Token: 0x060060EA RID: 24810
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkX3DExporter_WriteToOutputStringOn_31(HandleRef pThis);

		/// <summary>
		/// Enable writing to an OutputString instead of the default, a file.
		/// </summary>
		// Token: 0x060060EB RID: 24811 RVA: 0x0008B876 File Offset: 0x00089A76
		public virtual void WriteToOutputStringOn()
		{
			vtkX3DExporter.vtkX3DExporter_WriteToOutputStringOn_31(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040008B6 RID: 2230
		public new const string MRFullTypeName = "Kitware.VTK.vtkX3DExporter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040008B7 RID: 2231
		public new static readonly string MRClassNameKey = "class vtkX3DExporter";
	}
}
