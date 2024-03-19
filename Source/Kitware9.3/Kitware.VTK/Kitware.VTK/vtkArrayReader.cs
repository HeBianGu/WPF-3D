using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkArrayReader
	/// </summary>
	/// <remarks>
	///     Reads sparse and dense vtkArray data written by vtkArrayWriter.
	///
	///
	/// Reads sparse and dense vtkArray data written with vtkArrayWriter.
	///
	/// Outputs:
	///   Output port 0: vtkArrayData containing a dense or sparse array.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkArrayWriter
	///
	/// @par Thanks:
	/// Developed by Timothy M. Shead (tsheadndia.gov) at Sandia National Laboratories.
	/// </seealso>
	// Token: 0x0200071E RID: 1822
	public class vtkArrayReader : vtkArrayDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06013129 RID: 78121 RVA: 0x001AF371 File Offset: 0x001AD571
		static vtkArrayReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkArrayReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkArrayReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601312A RID: 78122 RVA: 0x001AF399 File Offset: 0x001AD599
		public vtkArrayReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601312B RID: 78123
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArrayReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601312C RID: 78124 RVA: 0x001AF3A8 File Offset: 0x001AD5A8
		public new static vtkArrayReader New()
		{
			vtkArrayReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkArrayReader.vtkArrayReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkArrayReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601312D RID: 78125 RVA: 0x001AF3FC File Offset: 0x001AD5FC
		public vtkArrayReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkArrayReader.vtkArrayReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601312E RID: 78126 RVA: 0x001AF440 File Offset: 0x001AD640
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601312F RID: 78127
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArrayReader_GetFileName_01(HandleRef pThis);

		/// <summary>
		/// Set the filesystem location from which data will be read.
		/// </summary>
		// Token: 0x06013130 RID: 78128 RVA: 0x001AF44C File Offset: 0x001AD64C
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkArrayReader.vtkArrayReader_GetFileName_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013131 RID: 78129
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkArrayReader_GetInputString_02(HandleRef pThis);

		/// <summary>
		/// The input string to parse. If you set the input string, you must also set
		/// the ReadFromInputString flag to parse the string instead of a file.
		/// </summary>
		// Token: 0x06013132 RID: 78130 RVA: 0x001AF488 File Offset: 0x001AD688
		public virtual string GetInputString()
		{
			return vtkArrayReader.vtkArrayReader_GetInputString_02(base.GetCppThis());
		}

		// Token: 0x06013133 RID: 78131
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkArrayReader_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013134 RID: 78132 RVA: 0x001AF4A8 File Offset: 0x001AD6A8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkArrayReader.vtkArrayReader_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06013135 RID: 78133
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkArrayReader_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013136 RID: 78134 RVA: 0x001AF4C8 File Offset: 0x001AD6C8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkArrayReader.vtkArrayReader_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06013137 RID: 78135
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkArrayReader_GetReadFromInputString_05(HandleRef pThis);

		/// <summary>
		/// Whether to read from an input string as opposed to a file, which is the default.
		/// </summary>
		// Token: 0x06013138 RID: 78136 RVA: 0x001AF4E4 File Offset: 0x001AD6E4
		public virtual bool GetReadFromInputString()
		{
			return vtkArrayReader.vtkArrayReader_GetReadFromInputString_05(base.GetCppThis()) != 0;
		}

		// Token: 0x06013139 RID: 78137
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArrayReader_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601313A RID: 78138 RVA: 0x001AF50C File Offset: 0x001AD70C
		public override int IsA(string type)
		{
			return vtkArrayReader.vtkArrayReader_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0601313B RID: 78139
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArrayReader_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601313C RID: 78140 RVA: 0x001AF52C File Offset: 0x001AD72C
		public new static int IsTypeOf(string type)
		{
			return vtkArrayReader.vtkArrayReader_IsTypeOf_07(type);
		}

		// Token: 0x0601313D RID: 78141
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArrayReader_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601313E RID: 78142 RVA: 0x001AF548 File Offset: 0x001AD748
		public new vtkArrayReader NewInstance()
		{
			vtkArrayReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkArrayReader.vtkArrayReader_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkArrayReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601313F RID: 78143
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArrayReader_Read_10([MarshalAs(UnmanagedType.LPUTF8Str)] string str, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Read an arbitrary array from a string.
		/// </summary>
		// Token: 0x06013140 RID: 78144 RVA: 0x001AF5A4 File Offset: 0x001AD7A4
		public static vtkArray Read(string str)
		{
			vtkArray vtkArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkArrayReader.vtkArrayReader_Read_10(str, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkArray = (vtkArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkArray.Register(null);
				}
			}
			return vtkArray;
		}

		// Token: 0x06013141 RID: 78145
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayReader_ReadFromInputStringOff_11(HandleRef pThis);

		/// <summary>
		/// Whether to read from an input string as opposed to a file, which is the default.
		/// </summary>
		// Token: 0x06013142 RID: 78146 RVA: 0x001AF60E File Offset: 0x001AD80E
		public virtual void ReadFromInputStringOff()
		{
			vtkArrayReader.vtkArrayReader_ReadFromInputStringOff_11(base.GetCppThis());
		}

		// Token: 0x06013143 RID: 78147
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayReader_ReadFromInputStringOn_12(HandleRef pThis);

		/// <summary>
		/// Whether to read from an input string as opposed to a file, which is the default.
		/// </summary>
		// Token: 0x06013144 RID: 78148 RVA: 0x001AF61D File Offset: 0x001AD81D
		public virtual void ReadFromInputStringOn()
		{
			vtkArrayReader.vtkArrayReader_ReadFromInputStringOn_12(base.GetCppThis());
		}

		// Token: 0x06013145 RID: 78149
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArrayReader_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013146 RID: 78150 RVA: 0x001AF62C File Offset: 0x001AD82C
		public new static vtkArrayReader SafeDownCast(vtkObjectBase o)
		{
			vtkArrayReader vtkArrayReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkArrayReader.vtkArrayReader_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkArrayReader = (vtkArrayReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkArrayReader.Register(null);
				}
			}
			return vtkArrayReader;
		}

		// Token: 0x06013147 RID: 78151
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayReader_SetFileName_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set the filesystem location from which data will be read.
		/// </summary>
		// Token: 0x06013148 RID: 78152 RVA: 0x001AF6AB File Offset: 0x001AD8AB
		public virtual void SetFileName(string _arg)
		{
			vtkArrayReader.vtkArrayReader_SetFileName_14(base.GetCppThis(), _arg);
		}

		// Token: 0x06013149 RID: 78153
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayReader_SetInputString_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// The input string to parse. If you set the input string, you must also set
		/// the ReadFromInputString flag to parse the string instead of a file.
		/// </summary>
		// Token: 0x0601314A RID: 78154 RVA: 0x001AF6BB File Offset: 0x001AD8BB
		public virtual void SetInputString(string arg0)
		{
			vtkArrayReader.vtkArrayReader_SetInputString_15(base.GetCppThis(), arg0);
		}

		// Token: 0x0601314B RID: 78155
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayReader_SetReadFromInputString_16(HandleRef pThis, byte _arg);

		/// <summary>
		/// Whether to read from an input string as opposed to a file, which is the default.
		/// </summary>
		// Token: 0x0601314C RID: 78156 RVA: 0x001AF6CB File Offset: 0x001AD8CB
		public virtual void SetReadFromInputString(bool _arg)
		{
			vtkArrayReader.vtkArrayReader_SetReadFromInputString_16(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001608 RID: 5640
		public new const string MRFullTypeName = "Kitware.VTK.vtkArrayReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001609 RID: 5641
		public new static readonly string MRClassNameKey = "class vtkArrayReader";
	}
}
