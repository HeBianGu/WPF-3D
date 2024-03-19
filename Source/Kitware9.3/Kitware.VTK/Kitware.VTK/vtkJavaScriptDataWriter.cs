using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkJavaScriptDataWriter
	/// </summary>
	/// <remarks>
	///    A Javascript data writer for vtkTable
	/// Writes a vtkTable into a Javascript data format.
	/// </remarks>
	// Token: 0x0200072D RID: 1837
	public class vtkJavaScriptDataWriter : vtkWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060132D2 RID: 78546 RVA: 0x001B1CCF File Offset: 0x001AFECF
		static vtkJavaScriptDataWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkJavaScriptDataWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkJavaScriptDataWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060132D3 RID: 78547 RVA: 0x001B1CF7 File Offset: 0x001AFEF7
		public vtkJavaScriptDataWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060132D4 RID: 78548
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkJavaScriptDataWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060132D5 RID: 78549 RVA: 0x001B1D08 File Offset: 0x001AFF08
		public new static vtkJavaScriptDataWriter New()
		{
			vtkJavaScriptDataWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkJavaScriptDataWriter.vtkJavaScriptDataWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkJavaScriptDataWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060132D6 RID: 78550 RVA: 0x001B1D5C File Offset: 0x001AFF5C
		public vtkJavaScriptDataWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkJavaScriptDataWriter.vtkJavaScriptDataWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060132D7 RID: 78551 RVA: 0x001B1DA0 File Offset: 0x001AFFA0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060132D8 RID: 78552
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkJavaScriptDataWriter_GetFileName_01(HandleRef pThis);

		/// <summary>
		/// Get/Set the filename for the file.
		/// </summary>
		// Token: 0x060132D9 RID: 78553 RVA: 0x001B1DAC File Offset: 0x001AFFAC
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkJavaScriptDataWriter.vtkJavaScriptDataWriter_GetFileName_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060132DA RID: 78554
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkJavaScriptDataWriter_GetIncludeFieldNames_02(HandleRef pThis);

		/// <summary>
		/// Get/Set the whether or not to include field names
		/// When field names are on you will get data output
		/// that looks like this:
		/// var data=[
		/// {foo:3,time:"2009-11-04 16:09:42",bar:1 },
		/// {foo:5,time:"2009-11-04 16:11:22",bar:0 },
		/// without field names the data will be an array
		/// of arrays like this:
		/// var data=[
		/// [3,"2009-11-04 16:09:42",1],
		/// [5,"2009-11-04 16:11:22",0],
		///
		/// Default is ON (true)
		/// </summary>
		// Token: 0x060132DB RID: 78555 RVA: 0x001B1DE8 File Offset: 0x001AFFE8
		public virtual bool GetIncludeFieldNames()
		{
			return vtkJavaScriptDataWriter.vtkJavaScriptDataWriter_GetIncludeFieldNames_02(base.GetCppThis()) != 0;
		}

		// Token: 0x060132DC RID: 78556
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkJavaScriptDataWriter_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060132DD RID: 78557 RVA: 0x001B1E10 File Offset: 0x001B0010
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkJavaScriptDataWriter.vtkJavaScriptDataWriter_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x060132DE RID: 78558
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkJavaScriptDataWriter_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060132DF RID: 78559 RVA: 0x001B1E30 File Offset: 0x001B0030
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkJavaScriptDataWriter.vtkJavaScriptDataWriter_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x060132E0 RID: 78560
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkJavaScriptDataWriter_GetVariableName_05(HandleRef pThis);

		/// <summary>
		/// Get/set the name of the Javascript variable that the dataset will be assigned to.
		/// The default value is "data", so the javascript code generated by the filter will
		/// look like this: "var data = [ ... ];". If VariableName is set to nullptr, then no
		/// assignment statement will be generated (i.e., only "[ ... ];" will be generated).
		/// </summary>
		// Token: 0x060132E1 RID: 78561 RVA: 0x001B1E4C File Offset: 0x001B004C
		public virtual string GetVariableName()
		{
			string s = Marshal.PtrToStringAnsi(vtkJavaScriptDataWriter.vtkJavaScriptDataWriter_GetVariableName_05(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060132E2 RID: 78562
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkJavaScriptDataWriter_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060132E3 RID: 78563 RVA: 0x001B1E88 File Offset: 0x001B0088
		public override int IsA(string type)
		{
			return vtkJavaScriptDataWriter.vtkJavaScriptDataWriter_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x060132E4 RID: 78564
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkJavaScriptDataWriter_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060132E5 RID: 78565 RVA: 0x001B1EA8 File Offset: 0x001B00A8
		public new static int IsTypeOf(string type)
		{
			return vtkJavaScriptDataWriter.vtkJavaScriptDataWriter_IsTypeOf_07(type);
		}

		// Token: 0x060132E6 RID: 78566
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkJavaScriptDataWriter_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060132E7 RID: 78567 RVA: 0x001B1EC4 File Offset: 0x001B00C4
		public new vtkJavaScriptDataWriter NewInstance()
		{
			vtkJavaScriptDataWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkJavaScriptDataWriter.vtkJavaScriptDataWriter_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkJavaScriptDataWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060132E8 RID: 78568
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkJavaScriptDataWriter_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060132E9 RID: 78569 RVA: 0x001B1F20 File Offset: 0x001B0120
		public new static vtkJavaScriptDataWriter SafeDownCast(vtkObjectBase o)
		{
			vtkJavaScriptDataWriter vtkJavaScriptDataWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkJavaScriptDataWriter.vtkJavaScriptDataWriter_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkJavaScriptDataWriter = (vtkJavaScriptDataWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkJavaScriptDataWriter.Register(null);
				}
			}
			return vtkJavaScriptDataWriter;
		}

		// Token: 0x060132EA RID: 78570
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkJavaScriptDataWriter_SetFileName_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Get/Set the filename for the file.
		/// </summary>
		// Token: 0x060132EB RID: 78571 RVA: 0x001B1F9F File Offset: 0x001B019F
		public virtual void SetFileName(string _arg)
		{
			vtkJavaScriptDataWriter.vtkJavaScriptDataWriter_SetFileName_11(base.GetCppThis(), _arg);
		}

		// Token: 0x060132EC RID: 78572
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkJavaScriptDataWriter_SetIncludeFieldNames_12(HandleRef pThis, byte _arg);

		/// <summary>
		/// Get/Set the whether or not to include field names
		/// When field names are on you will get data output
		/// that looks like this:
		/// var data=[
		/// {foo:3,time:"2009-11-04 16:09:42",bar:1 },
		/// {foo:5,time:"2009-11-04 16:11:22",bar:0 },
		/// without field names the data will be an array
		/// of arrays like this:
		/// var data=[
		/// [3,"2009-11-04 16:09:42",1],
		/// [5,"2009-11-04 16:11:22",0],
		///
		/// Default is ON (true)
		/// </summary>
		// Token: 0x060132ED RID: 78573 RVA: 0x001B1FAF File Offset: 0x001B01AF
		public virtual void SetIncludeFieldNames(bool _arg)
		{
			vtkJavaScriptDataWriter.vtkJavaScriptDataWriter_SetIncludeFieldNames_12(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060132EE RID: 78574
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkJavaScriptDataWriter_SetVariableName_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Get/set the name of the Javascript variable that the dataset will be assigned to.
		/// The default value is "data", so the javascript code generated by the filter will
		/// look like this: "var data = [ ... ];". If VariableName is set to nullptr, then no
		/// assignment statement will be generated (i.e., only "[ ... ];" will be generated).
		/// </summary>
		// Token: 0x060132EF RID: 78575 RVA: 0x001B1FC7 File Offset: 0x001B01C7
		public virtual void SetVariableName(string _arg)
		{
			vtkJavaScriptDataWriter.vtkJavaScriptDataWriter_SetVariableName_13(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001628 RID: 5672
		public new const string MRFullTypeName = "Kitware.VTK.vtkJavaScriptDataWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001629 RID: 5673
		public new static readonly string MRClassNameKey = "class vtkJavaScriptDataWriter";
	}
}
