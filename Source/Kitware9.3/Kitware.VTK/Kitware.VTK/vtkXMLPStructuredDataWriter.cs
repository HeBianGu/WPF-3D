using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkXMLPStructuredDataWriter
	/// </summary>
	/// <remarks>
	///    Superclass for PVTK XML structured data writers.
	///
	/// vtkXMLPStructuredDataWriter provides PVTK XML writing functionality
	/// that is common among all the parallel structured data formats.
	/// </remarks>
	// Token: 0x02000146 RID: 326
	public abstract class vtkXMLPStructuredDataWriter : vtkXMLPDataWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06003F29 RID: 16169 RVA: 0x0005C6B7 File Offset: 0x0005A8B7
		static vtkXMLPStructuredDataWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLPStructuredDataWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLPStructuredDataWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06003F2A RID: 16170 RVA: 0x0005C6DF File Offset: 0x0005A8DF
		public vtkXMLPStructuredDataWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06003F2B RID: 16171 RVA: 0x0005C6ED File Offset: 0x0005A8ED
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06003F2C RID: 16172
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLPStructuredDataWriter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003F2D RID: 16173 RVA: 0x0005C6F8 File Offset: 0x0005A8F8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLPStructuredDataWriter.vtkXMLPStructuredDataWriter_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06003F2E RID: 16174
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLPStructuredDataWriter_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003F2F RID: 16175 RVA: 0x0005C718 File Offset: 0x0005A918
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLPStructuredDataWriter.vtkXMLPStructuredDataWriter_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06003F30 RID: 16176
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPStructuredDataWriter_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003F31 RID: 16177 RVA: 0x0005C734 File Offset: 0x0005A934
		public override int IsA(string type)
		{
			return vtkXMLPStructuredDataWriter.vtkXMLPStructuredDataWriter_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06003F32 RID: 16178
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPStructuredDataWriter_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003F33 RID: 16179 RVA: 0x0005C754 File Offset: 0x0005A954
		public new static int IsTypeOf(string type)
		{
			return vtkXMLPStructuredDataWriter.vtkXMLPStructuredDataWriter_IsTypeOf_04(type);
		}

		// Token: 0x06003F34 RID: 16180
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPStructuredDataWriter_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003F35 RID: 16181 RVA: 0x0005C770 File Offset: 0x0005A970
		public new vtkXMLPStructuredDataWriter NewInstance()
		{
			vtkXMLPStructuredDataWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPStructuredDataWriter.vtkXMLPStructuredDataWriter_NewInstance_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPStructuredDataWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06003F36 RID: 16182
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPStructuredDataWriter_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003F37 RID: 16183 RVA: 0x0005C7CC File Offset: 0x0005A9CC
		public new static vtkXMLPStructuredDataWriter SafeDownCast(vtkObjectBase o)
		{
			vtkXMLPStructuredDataWriter vtkXMLPStructuredDataWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPStructuredDataWriter.vtkXMLPStructuredDataWriter_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLPStructuredDataWriter = (vtkXMLPStructuredDataWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLPStructuredDataWriter.Register(null);
				}
			}
			return vtkXMLPStructuredDataWriter;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040006D0 RID: 1744
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLPStructuredDataWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040006D1 RID: 1745
		public new static readonly string MRClassNameKey = "class vtkXMLPStructuredDataWriter";
	}
}
