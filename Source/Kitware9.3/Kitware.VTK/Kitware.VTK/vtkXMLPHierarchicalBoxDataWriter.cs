using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkXMLPHierarchicalBoxDataWriter
	/// </summary>
	/// <remarks>
	///    parallel writer for
	/// vtkHierarchicalBoxDataSet for backwards compatibility.
	///
	/// vtkXMLPHierarchicalBoxDataWriter is an empty subclass of
	/// vtkXMLPUniformGridAMRWriter for backwards compatibility.
	/// </remarks>
	// Token: 0x02000145 RID: 325
	public class vtkXMLPHierarchicalBoxDataWriter : vtkXMLPUniformGridAMRWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06003F17 RID: 16151 RVA: 0x0005C487 File Offset: 0x0005A687
		static vtkXMLPHierarchicalBoxDataWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLPHierarchicalBoxDataWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLPHierarchicalBoxDataWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06003F18 RID: 16152 RVA: 0x0005C4AF File Offset: 0x0005A6AF
		public vtkXMLPHierarchicalBoxDataWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06003F19 RID: 16153
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPHierarchicalBoxDataWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003F1A RID: 16154 RVA: 0x0005C4C0 File Offset: 0x0005A6C0
		public new static vtkXMLPHierarchicalBoxDataWriter New()
		{
			vtkXMLPHierarchicalBoxDataWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPHierarchicalBoxDataWriter.vtkXMLPHierarchicalBoxDataWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPHierarchicalBoxDataWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003F1B RID: 16155 RVA: 0x0005C514 File Offset: 0x0005A714
		public vtkXMLPHierarchicalBoxDataWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkXMLPHierarchicalBoxDataWriter.vtkXMLPHierarchicalBoxDataWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06003F1C RID: 16156 RVA: 0x0005C558 File Offset: 0x0005A758
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06003F1D RID: 16157
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLPHierarchicalBoxDataWriter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003F1E RID: 16158 RVA: 0x0005C564 File Offset: 0x0005A764
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLPHierarchicalBoxDataWriter.vtkXMLPHierarchicalBoxDataWriter_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06003F1F RID: 16159
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLPHierarchicalBoxDataWriter_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003F20 RID: 16160 RVA: 0x0005C584 File Offset: 0x0005A784
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLPHierarchicalBoxDataWriter.vtkXMLPHierarchicalBoxDataWriter_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06003F21 RID: 16161
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPHierarchicalBoxDataWriter_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003F22 RID: 16162 RVA: 0x0005C5A0 File Offset: 0x0005A7A0
		public override int IsA(string type)
		{
			return vtkXMLPHierarchicalBoxDataWriter.vtkXMLPHierarchicalBoxDataWriter_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06003F23 RID: 16163
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPHierarchicalBoxDataWriter_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003F24 RID: 16164 RVA: 0x0005C5C0 File Offset: 0x0005A7C0
		public new static int IsTypeOf(string type)
		{
			return vtkXMLPHierarchicalBoxDataWriter.vtkXMLPHierarchicalBoxDataWriter_IsTypeOf_04(type);
		}

		// Token: 0x06003F25 RID: 16165
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPHierarchicalBoxDataWriter_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003F26 RID: 16166 RVA: 0x0005C5DC File Offset: 0x0005A7DC
		public new vtkXMLPHierarchicalBoxDataWriter NewInstance()
		{
			vtkXMLPHierarchicalBoxDataWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPHierarchicalBoxDataWriter.vtkXMLPHierarchicalBoxDataWriter_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPHierarchicalBoxDataWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06003F27 RID: 16167
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPHierarchicalBoxDataWriter_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003F28 RID: 16168 RVA: 0x0005C638 File Offset: 0x0005A838
		public new static vtkXMLPHierarchicalBoxDataWriter SafeDownCast(vtkObjectBase o)
		{
			vtkXMLPHierarchicalBoxDataWriter vtkXMLPHierarchicalBoxDataWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPHierarchicalBoxDataWriter.vtkXMLPHierarchicalBoxDataWriter_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLPHierarchicalBoxDataWriter = (vtkXMLPHierarchicalBoxDataWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLPHierarchicalBoxDataWriter.Register(null);
				}
			}
			return vtkXMLPHierarchicalBoxDataWriter;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040006CE RID: 1742
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLPHierarchicalBoxDataWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040006CF RID: 1743
		public new static readonly string MRClassNameKey = "class vtkXMLPHierarchicalBoxDataWriter";
	}
}
