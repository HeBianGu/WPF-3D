using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCellGridReader
	/// </summary>
	/// <remarks>
	///    Read a cell-grid file.
	///
	/// vtkCellGridReader is a concrete subclass of vtkCellGridAlgorithm that reads data
	/// into a vtkCellGrid instance (which is really just a collection of array groups).
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkCellGridAlgorithm
	/// vtkCellGridImporter
	/// </seealso>
	// Token: 0x020001DC RID: 476
	public class vtkCellGridReader : vtkCellGridAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06005AEE RID: 23278 RVA: 0x000839D7 File Offset: 0x00081BD7
		static vtkCellGridReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCellGridReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellGridReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06005AEF RID: 23279 RVA: 0x000839FF File Offset: 0x00081BFF
		public vtkCellGridReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06005AF0 RID: 23280
		[DllImport("Kitware.VTK.IOCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005AF1 RID: 23281 RVA: 0x00083A10 File Offset: 0x00081C10
		public new static vtkCellGridReader New()
		{
			vtkCellGridReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridReader.vtkCellGridReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellGridReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005AF2 RID: 23282 RVA: 0x00083A64 File Offset: 0x00081C64
		public vtkCellGridReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCellGridReader.vtkCellGridReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06005AF3 RID: 23283 RVA: 0x00083AA8 File Offset: 0x00081CA8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06005AF4 RID: 23284
		[DllImport("Kitware.VTK.IOCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridReader_GetFileName_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the name of the file from which to read data.
		/// </summary>
		// Token: 0x06005AF5 RID: 23285 RVA: 0x00083AB4 File Offset: 0x00081CB4
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkCellGridReader.vtkCellGridReader_GetFileName_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06005AF6 RID: 23286
		[DllImport("Kitware.VTK.IOCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellGridReader_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005AF7 RID: 23287 RVA: 0x00083AF0 File Offset: 0x00081CF0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCellGridReader.vtkCellGridReader_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06005AF8 RID: 23288
		[DllImport("Kitware.VTK.IOCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellGridReader_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005AF9 RID: 23289 RVA: 0x00083B10 File Offset: 0x00081D10
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCellGridReader.vtkCellGridReader_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06005AFA RID: 23290
		[DllImport("Kitware.VTK.IOCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellGridReader_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005AFB RID: 23291 RVA: 0x00083B2C File Offset: 0x00081D2C
		public override int IsA(string type)
		{
			return vtkCellGridReader.vtkCellGridReader_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06005AFC RID: 23292
		[DllImport("Kitware.VTK.IOCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellGridReader_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005AFD RID: 23293 RVA: 0x00083B4C File Offset: 0x00081D4C
		public new static int IsTypeOf(string type)
		{
			return vtkCellGridReader.vtkCellGridReader_IsTypeOf_05(type);
		}

		// Token: 0x06005AFE RID: 23294
		[DllImport("Kitware.VTK.IOCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridReader_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005AFF RID: 23295 RVA: 0x00083B68 File Offset: 0x00081D68
		public new vtkCellGridReader NewInstance()
		{
			vtkCellGridReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridReader.vtkCellGridReader_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellGridReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06005B00 RID: 23296
		[DllImport("Kitware.VTK.IOCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridReader_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005B01 RID: 23297 RVA: 0x00083BC4 File Offset: 0x00081DC4
		public new static vtkCellGridReader SafeDownCast(vtkObjectBase o)
		{
			vtkCellGridReader vtkCellGridReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridReader.vtkCellGridReader_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellGridReader = (vtkCellGridReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellGridReader.Register(null);
				}
			}
			return vtkCellGridReader;
		}

		// Token: 0x06005B02 RID: 23298
		[DllImport("Kitware.VTK.IOCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGridReader_SetFileName_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the name of the file from which to read data.
		/// </summary>
		// Token: 0x06005B03 RID: 23299 RVA: 0x00083C43 File Offset: 0x00081E43
		public virtual void SetFileName(string _arg)
		{
			vtkCellGridReader.vtkCellGridReader_SetFileName_09(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000881 RID: 2177
		public new const string MRFullTypeName = "Kitware.VTK.vtkCellGridReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000882 RID: 2178
		public new static readonly string MRClassNameKey = "class vtkCellGridReader";
	}
}
