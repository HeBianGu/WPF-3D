using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkXMLPUnstructuredDataWriter
	/// </summary>
	/// <remarks>
	///    Superclass for PVTK XML unstructured data writers.
	///
	/// vtkXMLPUnstructuredDataWriter provides PVTK XML writing
	/// functionality that is common among all the parallel unstructured
	/// data formats.
	/// </remarks>
	// Token: 0x0200014A RID: 330
	public abstract class vtkXMLPUnstructuredDataWriter : vtkXMLPDataWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06003F82 RID: 16258 RVA: 0x0005D0D3 File Offset: 0x0005B2D3
		static vtkXMLPUnstructuredDataWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLPUnstructuredDataWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLPUnstructuredDataWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06003F83 RID: 16259 RVA: 0x0005D0FB File Offset: 0x0005B2FB
		public vtkXMLPUnstructuredDataWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06003F84 RID: 16260 RVA: 0x0005D109 File Offset: 0x0005B309
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06003F85 RID: 16261
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLPUnstructuredDataWriter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003F86 RID: 16262 RVA: 0x0005D114 File Offset: 0x0005B314
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLPUnstructuredDataWriter.vtkXMLPUnstructuredDataWriter_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06003F87 RID: 16263
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLPUnstructuredDataWriter_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003F88 RID: 16264 RVA: 0x0005D134 File Offset: 0x0005B334
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLPUnstructuredDataWriter.vtkXMLPUnstructuredDataWriter_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06003F89 RID: 16265
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPUnstructuredDataWriter_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003F8A RID: 16266 RVA: 0x0005D150 File Offset: 0x0005B350
		public override int IsA(string type)
		{
			return vtkXMLPUnstructuredDataWriter.vtkXMLPUnstructuredDataWriter_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06003F8B RID: 16267
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPUnstructuredDataWriter_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003F8C RID: 16268 RVA: 0x0005D170 File Offset: 0x0005B370
		public new static int IsTypeOf(string type)
		{
			return vtkXMLPUnstructuredDataWriter.vtkXMLPUnstructuredDataWriter_IsTypeOf_04(type);
		}

		// Token: 0x06003F8D RID: 16269
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPUnstructuredDataWriter_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003F8E RID: 16270 RVA: 0x0005D18C File Offset: 0x0005B38C
		public new vtkXMLPUnstructuredDataWriter NewInstance()
		{
			vtkXMLPUnstructuredDataWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPUnstructuredDataWriter.vtkXMLPUnstructuredDataWriter_NewInstance_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPUnstructuredDataWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06003F8F RID: 16271
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPUnstructuredDataWriter_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003F90 RID: 16272 RVA: 0x0005D1E8 File Offset: 0x0005B3E8
		public new static vtkXMLPUnstructuredDataWriter SafeDownCast(vtkObjectBase o)
		{
			vtkXMLPUnstructuredDataWriter vtkXMLPUnstructuredDataWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPUnstructuredDataWriter.vtkXMLPUnstructuredDataWriter_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLPUnstructuredDataWriter = (vtkXMLPUnstructuredDataWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLPUnstructuredDataWriter.Register(null);
				}
			}
			return vtkXMLPUnstructuredDataWriter;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040006D8 RID: 1752
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLPUnstructuredDataWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040006D9 RID: 1753
		public new static readonly string MRClassNameKey = "class vtkXMLPUnstructuredDataWriter";
	}
}
