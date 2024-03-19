using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPhyloXMLTreeReader
	/// </summary>
	/// <remarks>
	///    read vtkTree from PhyloXML formatted file
	///
	/// vtkPhyloXMLTreeReader is a source object that reads PhyloXML tree format
	/// files.
	/// The output of this reader is a single vtkTree data object.
	///
	///
	/// @warning
	/// This reader does not implement the entire PhyloXML specification.
	/// It currently only supports the following tags:
	/// phylogeny, name, description, confidence, property, clade, branch_length,
	/// color, red, green, and blue.
	/// This reader also only supports a single phylogeny per file.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkTree vtkXMLReader vtkPhyloXMLTreeWriter
	/// </seealso>
	// Token: 0x020001A3 RID: 419
	public class vtkPhyloXMLTreeReader : vtkXMLReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060051B0 RID: 20912 RVA: 0x00076EA4 File Offset: 0x000750A4
		static vtkPhyloXMLTreeReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPhyloXMLTreeReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPhyloXMLTreeReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060051B1 RID: 20913 RVA: 0x00076ECC File Offset: 0x000750CC
		public vtkPhyloXMLTreeReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060051B2 RID: 20914
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPhyloXMLTreeReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060051B3 RID: 20915 RVA: 0x00076EDC File Offset: 0x000750DC
		public new static vtkPhyloXMLTreeReader New()
		{
			vtkPhyloXMLTreeReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPhyloXMLTreeReader.vtkPhyloXMLTreeReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPhyloXMLTreeReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060051B4 RID: 20916 RVA: 0x00076F30 File Offset: 0x00075130
		public vtkPhyloXMLTreeReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPhyloXMLTreeReader.vtkPhyloXMLTreeReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060051B5 RID: 20917 RVA: 0x00076F74 File Offset: 0x00075174
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060051B6 RID: 20918
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPhyloXMLTreeReader_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060051B7 RID: 20919 RVA: 0x00076F80 File Offset: 0x00075180
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPhyloXMLTreeReader.vtkPhyloXMLTreeReader_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x060051B8 RID: 20920
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPhyloXMLTreeReader_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060051B9 RID: 20921 RVA: 0x00076FA0 File Offset: 0x000751A0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPhyloXMLTreeReader.vtkPhyloXMLTreeReader_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x060051BA RID: 20922
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPhyloXMLTreeReader_GetOutput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output of this reader.
		/// </summary>
		// Token: 0x060051BB RID: 20923 RVA: 0x00076FBC File Offset: 0x000751BC
		public vtkTree GetOutput()
		{
			vtkTree vtkTree = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPhyloXMLTreeReader.vtkPhyloXMLTreeReader_GetOutput_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTree = (vtkTree)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTree.Register(null);
				}
			}
			return vtkTree;
		}

		// Token: 0x060051BC RID: 20924
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPhyloXMLTreeReader_GetOutput_04(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output of this reader.
		/// </summary>
		// Token: 0x060051BD RID: 20925 RVA: 0x0007702C File Offset: 0x0007522C
		public vtkTree GetOutput(int idx)
		{
			vtkTree vtkTree = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPhyloXMLTreeReader.vtkPhyloXMLTreeReader_GetOutput_04(base.GetCppThis(), idx, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTree = (vtkTree)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTree.Register(null);
				}
			}
			return vtkTree;
		}

		// Token: 0x060051BE RID: 20926
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPhyloXMLTreeReader_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060051BF RID: 20927 RVA: 0x0007709C File Offset: 0x0007529C
		public override int IsA(string type)
		{
			return vtkPhyloXMLTreeReader.vtkPhyloXMLTreeReader_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x060051C0 RID: 20928
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPhyloXMLTreeReader_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060051C1 RID: 20929 RVA: 0x000770BC File Offset: 0x000752BC
		public new static int IsTypeOf(string type)
		{
			return vtkPhyloXMLTreeReader.vtkPhyloXMLTreeReader_IsTypeOf_06(type);
		}

		// Token: 0x060051C2 RID: 20930
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPhyloXMLTreeReader_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060051C3 RID: 20931 RVA: 0x000770D8 File Offset: 0x000752D8
		public new vtkPhyloXMLTreeReader NewInstance()
		{
			vtkPhyloXMLTreeReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPhyloXMLTreeReader.vtkPhyloXMLTreeReader_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPhyloXMLTreeReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060051C4 RID: 20932
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPhyloXMLTreeReader_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060051C5 RID: 20933 RVA: 0x00077134 File Offset: 0x00075334
		public new static vtkPhyloXMLTreeReader SafeDownCast(vtkObjectBase o)
		{
			vtkPhyloXMLTreeReader vtkPhyloXMLTreeReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPhyloXMLTreeReader.vtkPhyloXMLTreeReader_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPhyloXMLTreeReader = (vtkPhyloXMLTreeReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPhyloXMLTreeReader.Register(null);
				}
			}
			return vtkPhyloXMLTreeReader;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040007AB RID: 1963
		public new const string MRFullTypeName = "Kitware.VTK.vtkPhyloXMLTreeReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040007AC RID: 1964
		public new static readonly string MRClassNameKey = "class vtkPhyloXMLTreeReader";
	}
}
