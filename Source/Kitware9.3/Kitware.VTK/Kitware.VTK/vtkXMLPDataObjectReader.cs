using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkXMLPDataObjectReader
	/// </summary>
	/// <remarks>
	///    Superclass for PVTK XML file readers.
	///
	/// vtkXMLPDataObjectReader provides functionality common to all PVTK XML
	/// file readers. Concrete subclasses call upon this functionality when needed.
	/// </remarks>
	// Token: 0x020006D3 RID: 1747
	public abstract class vtkXMLPDataObjectReader : vtkXMLReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060128A9 RID: 75945 RVA: 0x001A0217 File Offset: 0x0019E417
		static vtkXMLPDataObjectReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLPDataObjectReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLPDataObjectReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060128AA RID: 75946 RVA: 0x001A023F File Offset: 0x0019E43F
		public vtkXMLPDataObjectReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060128AB RID: 75947 RVA: 0x001A024D File Offset: 0x0019E44D
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060128AC RID: 75948
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLPDataObjectReader_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060128AD RID: 75949 RVA: 0x001A0258 File Offset: 0x0019E458
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLPDataObjectReader.vtkXMLPDataObjectReader_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x060128AE RID: 75950
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLPDataObjectReader_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060128AF RID: 75951 RVA: 0x001A0278 File Offset: 0x0019E478
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLPDataObjectReader.vtkXMLPDataObjectReader_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x060128B0 RID: 75952
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPDataObjectReader_GetNumberOfPieces_03(HandleRef pThis);

		/// <summary>
		/// Get the number of pieces from the summary file being read.
		/// </summary>
		// Token: 0x060128B1 RID: 75953 RVA: 0x001A0294 File Offset: 0x0019E494
		public virtual int GetNumberOfPieces()
		{
			return vtkXMLPDataObjectReader.vtkXMLPDataObjectReader_GetNumberOfPieces_03(base.GetCppThis());
		}

		// Token: 0x060128B2 RID: 75954
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPDataObjectReader_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060128B3 RID: 75955 RVA: 0x001A02B4 File Offset: 0x0019E4B4
		public override int IsA(string type)
		{
			return vtkXMLPDataObjectReader.vtkXMLPDataObjectReader_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x060128B4 RID: 75956
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPDataObjectReader_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060128B5 RID: 75957 RVA: 0x001A02D4 File Offset: 0x0019E4D4
		public new static int IsTypeOf(string type)
		{
			return vtkXMLPDataObjectReader.vtkXMLPDataObjectReader_IsTypeOf_05(type);
		}

		// Token: 0x060128B6 RID: 75958
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPDataObjectReader_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060128B7 RID: 75959 RVA: 0x001A02F0 File Offset: 0x0019E4F0
		public new vtkXMLPDataObjectReader NewInstance()
		{
			vtkXMLPDataObjectReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPDataObjectReader.vtkXMLPDataObjectReader_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPDataObjectReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060128B8 RID: 75960
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPDataObjectReader_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060128B9 RID: 75961 RVA: 0x001A034C File Offset: 0x0019E54C
		public new static vtkXMLPDataObjectReader SafeDownCast(vtkObjectBase o)
		{
			vtkXMLPDataObjectReader vtkXMLPDataObjectReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPDataObjectReader.vtkXMLPDataObjectReader_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLPDataObjectReader = (vtkXMLPDataObjectReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLPDataObjectReader.Register(null);
				}
			}
			return vtkXMLPDataObjectReader;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001557 RID: 5463
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLPDataObjectReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001558 RID: 5464
		public new static readonly string MRClassNameKey = "class vtkXMLPDataObjectReader";
	}
}
