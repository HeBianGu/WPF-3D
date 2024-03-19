using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkISIReader
	/// </summary>
	/// <remarks>
	///    reader for ISI files
	///
	///
	/// ISI is a tagged format for expressing bibliographic citations.  Data is
	/// structured as a collection of records with each record composed of
	/// one-to-many fields.  See
	///
	/// http://isibasic.com/help/helpprn.html#dialog_export_format
	///
	/// for details.  vtkISIReader will convert an ISI file into a vtkTable, with
	/// the set of table columns determined dynamically from the contents of the
	/// file.
	/// </remarks>
	// Token: 0x0200019D RID: 413
	public class vtkISIReader : vtkTableAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060050D7 RID: 20695 RVA: 0x00075721 File Offset: 0x00073921
		static vtkISIReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkISIReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkISIReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060050D8 RID: 20696 RVA: 0x00075749 File Offset: 0x00073949
		public vtkISIReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060050D9 RID: 20697
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkISIReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060050DA RID: 20698 RVA: 0x00075758 File Offset: 0x00073958
		public new static vtkISIReader New()
		{
			vtkISIReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkISIReader.vtkISIReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkISIReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060050DB RID: 20699 RVA: 0x000757AC File Offset: 0x000739AC
		public vtkISIReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkISIReader.vtkISIReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060050DC RID: 20700 RVA: 0x000757F0 File Offset: 0x000739F0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060050DD RID: 20701
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkISIReader_GetDelimiter_01(HandleRef pThis);

		/// <summary>
		/// Set/get the delimiter to be used for concatenating field data (default: ";")
		/// </summary>
		// Token: 0x060050DE RID: 20702 RVA: 0x000757FC File Offset: 0x000739FC
		public virtual string GetDelimiter()
		{
			string s = Marshal.PtrToStringAnsi(vtkISIReader.vtkISIReader_GetDelimiter_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060050DF RID: 20703
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkISIReader_GetFileName_02(HandleRef pThis);

		/// <summary>
		/// Set/get the file to load
		/// </summary>
		// Token: 0x060050E0 RID: 20704 RVA: 0x00075838 File Offset: 0x00073A38
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkISIReader.vtkISIReader_GetFileName_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060050E1 RID: 20705
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkISIReader_GetMaxRecords_03(HandleRef pThis);

		/// <summary>
		/// Set/get the maximum number of records to read from the file (zero = unlimited)
		/// </summary>
		// Token: 0x060050E2 RID: 20706 RVA: 0x00075874 File Offset: 0x00073A74
		public virtual int GetMaxRecords()
		{
			return vtkISIReader.vtkISIReader_GetMaxRecords_03(base.GetCppThis());
		}

		// Token: 0x060050E3 RID: 20707
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkISIReader_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060050E4 RID: 20708 RVA: 0x00075894 File Offset: 0x00073A94
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkISIReader.vtkISIReader_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x060050E5 RID: 20709
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkISIReader_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060050E6 RID: 20710 RVA: 0x000758B4 File Offset: 0x00073AB4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkISIReader.vtkISIReader_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x060050E7 RID: 20711
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkISIReader_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060050E8 RID: 20712 RVA: 0x000758D0 File Offset: 0x00073AD0
		public override int IsA(string type)
		{
			return vtkISIReader.vtkISIReader_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x060050E9 RID: 20713
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkISIReader_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060050EA RID: 20714 RVA: 0x000758F0 File Offset: 0x00073AF0
		public new static int IsTypeOf(string type)
		{
			return vtkISIReader.vtkISIReader_IsTypeOf_07(type);
		}

		// Token: 0x060050EB RID: 20715
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkISIReader_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060050EC RID: 20716 RVA: 0x0007590C File Offset: 0x00073B0C
		public new vtkISIReader NewInstance()
		{
			vtkISIReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkISIReader.vtkISIReader_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkISIReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060050ED RID: 20717
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkISIReader_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060050EE RID: 20718 RVA: 0x00075968 File Offset: 0x00073B68
		public new static vtkISIReader SafeDownCast(vtkObjectBase o)
		{
			vtkISIReader vtkISIReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkISIReader.vtkISIReader_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkISIReader = (vtkISIReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkISIReader.Register(null);
				}
			}
			return vtkISIReader;
		}

		// Token: 0x060050EF RID: 20719
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkISIReader_SetDelimiter_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/get the delimiter to be used for concatenating field data (default: ";")
		/// </summary>
		// Token: 0x060050F0 RID: 20720 RVA: 0x000759E7 File Offset: 0x00073BE7
		public virtual void SetDelimiter(string _arg)
		{
			vtkISIReader.vtkISIReader_SetDelimiter_11(base.GetCppThis(), _arg);
		}

		// Token: 0x060050F1 RID: 20721
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkISIReader_SetFileName_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/get the file to load
		/// </summary>
		// Token: 0x060050F2 RID: 20722 RVA: 0x000759F7 File Offset: 0x00073BF7
		public virtual void SetFileName(string _arg)
		{
			vtkISIReader.vtkISIReader_SetFileName_12(base.GetCppThis(), _arg);
		}

		// Token: 0x060050F3 RID: 20723
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkISIReader_SetMaxRecords_13(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the maximum number of records to read from the file (zero = unlimited)
		/// </summary>
		// Token: 0x060050F4 RID: 20724 RVA: 0x00075A07 File Offset: 0x00073C07
		public virtual void SetMaxRecords(int _arg)
		{
			vtkISIReader.vtkISIReader_SetMaxRecords_13(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400079D RID: 1949
		public new const string MRFullTypeName = "Kitware.VTK.vtkISIReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400079E RID: 1950
		public new static readonly string MRClassNameKey = "class vtkISIReader";
	}
}
