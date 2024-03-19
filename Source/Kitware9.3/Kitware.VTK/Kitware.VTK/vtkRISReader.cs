using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkRISReader
	/// </summary>
	/// <remarks>
	///    reader for RIS files
	///
	///
	/// RIS is a tagged format for expressing bibliographic citations.  Data is
	/// structured as a collection of records with each record composed of
	/// one-to-many fields.  See
	///
	/// http://en.wikipedia.org/wiki/RIS_(file_format)
	/// http://www.refman.com/support/risformat_intro.asp
	/// http://www.adeptscience.co.uk/kb/article/A626
	///
	/// for details.  vtkRISReader will convert an RIS file into a vtkTable, with
	/// the set of table columns determined dynamically from the contents of the
	/// file.
	/// </remarks>
	// Token: 0x020001A5 RID: 421
	public class vtkRISReader : vtkTableAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060051E8 RID: 20968 RVA: 0x0007756F File Offset: 0x0007576F
		static vtkRISReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRISReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRISReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060051E9 RID: 20969 RVA: 0x00077597 File Offset: 0x00075797
		public vtkRISReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060051EA RID: 20970
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRISReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060051EB RID: 20971 RVA: 0x000775A8 File Offset: 0x000757A8
		public new static vtkRISReader New()
		{
			vtkRISReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRISReader.vtkRISReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRISReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060051EC RID: 20972 RVA: 0x000775FC File Offset: 0x000757FC
		public vtkRISReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkRISReader.vtkRISReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060051ED RID: 20973 RVA: 0x00077640 File Offset: 0x00075840
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060051EE RID: 20974
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRISReader_GetDelimiter_01(HandleRef pThis);

		/// <summary>
		/// Set/get the delimiter to be used for concatenating field data (default: ";")
		/// </summary>
		// Token: 0x060051EF RID: 20975 RVA: 0x0007764C File Offset: 0x0007584C
		public virtual string GetDelimiter()
		{
			string s = Marshal.PtrToStringAnsi(vtkRISReader.vtkRISReader_GetDelimiter_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060051F0 RID: 20976
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRISReader_GetFileName_02(HandleRef pThis);

		/// <summary>
		/// Set/get the file to load
		/// </summary>
		// Token: 0x060051F1 RID: 20977 RVA: 0x00077688 File Offset: 0x00075888
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkRISReader.vtkRISReader_GetFileName_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060051F2 RID: 20978
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRISReader_GetMaxRecords_03(HandleRef pThis);

		/// <summary>
		/// Set/get the maximum number of records to read from the file (zero = unlimited)
		/// </summary>
		// Token: 0x060051F3 RID: 20979 RVA: 0x000776C4 File Offset: 0x000758C4
		public virtual int GetMaxRecords()
		{
			return vtkRISReader.vtkRISReader_GetMaxRecords_03(base.GetCppThis());
		}

		// Token: 0x060051F4 RID: 20980
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRISReader_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060051F5 RID: 20981 RVA: 0x000776E4 File Offset: 0x000758E4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRISReader.vtkRISReader_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x060051F6 RID: 20982
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRISReader_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060051F7 RID: 20983 RVA: 0x00077704 File Offset: 0x00075904
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRISReader.vtkRISReader_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x060051F8 RID: 20984
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRISReader_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060051F9 RID: 20985 RVA: 0x00077720 File Offset: 0x00075920
		public override int IsA(string type)
		{
			return vtkRISReader.vtkRISReader_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x060051FA RID: 20986
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRISReader_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060051FB RID: 20987 RVA: 0x00077740 File Offset: 0x00075940
		public new static int IsTypeOf(string type)
		{
			return vtkRISReader.vtkRISReader_IsTypeOf_07(type);
		}

		// Token: 0x060051FC RID: 20988
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRISReader_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060051FD RID: 20989 RVA: 0x0007775C File Offset: 0x0007595C
		public new vtkRISReader NewInstance()
		{
			vtkRISReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRISReader.vtkRISReader_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRISReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060051FE RID: 20990
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRISReader_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060051FF RID: 20991 RVA: 0x000777B8 File Offset: 0x000759B8
		public new static vtkRISReader SafeDownCast(vtkObjectBase o)
		{
			vtkRISReader vtkRISReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRISReader.vtkRISReader_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRISReader = (vtkRISReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRISReader.Register(null);
				}
			}
			return vtkRISReader;
		}

		// Token: 0x06005200 RID: 20992
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRISReader_SetDelimiter_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/get the delimiter to be used for concatenating field data (default: ";")
		/// </summary>
		// Token: 0x06005201 RID: 20993 RVA: 0x00077837 File Offset: 0x00075A37
		public virtual void SetDelimiter(string _arg)
		{
			vtkRISReader.vtkRISReader_SetDelimiter_11(base.GetCppThis(), _arg);
		}

		// Token: 0x06005202 RID: 20994
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRISReader_SetFileName_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/get the file to load
		/// </summary>
		// Token: 0x06005203 RID: 20995 RVA: 0x00077847 File Offset: 0x00075A47
		public virtual void SetFileName(string _arg)
		{
			vtkRISReader.vtkRISReader_SetFileName_12(base.GetCppThis(), _arg);
		}

		// Token: 0x06005204 RID: 20996
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRISReader_SetMaxRecords_13(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the maximum number of records to read from the file (zero = unlimited)
		/// </summary>
		// Token: 0x06005205 RID: 20997 RVA: 0x00077857 File Offset: 0x00075A57
		public virtual void SetMaxRecords(int _arg)
		{
			vtkRISReader.vtkRISReader_SetMaxRecords_13(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040007AF RID: 1967
		public new const string MRFullTypeName = "Kitware.VTK.vtkRISReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040007B0 RID: 1968
		public new static readonly string MRClassNameKey = "class vtkRISReader";
	}
}
