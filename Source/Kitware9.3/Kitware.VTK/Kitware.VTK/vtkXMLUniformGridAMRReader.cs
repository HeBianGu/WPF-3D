using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkXMLUniformGridAMRReader
	/// </summary>
	/// <remarks>
	///    Reader for amr datasets (vtkOverlappingAMR
	/// or vtkNonOverlappingAMR).
	///
	/// vtkXMLUniformGridAMRReader reads the VTK XML data files for all types of amr
	/// datasets including vtkOverlappingAMR, vtkNonOverlappingAMR and the legacy
	/// vtkHierarchicalBoxDataSet. The reader uses information in the file to
	/// determine what type of dataset is actually being read and creates the
	/// output-data object accordingly.
	///
	/// This reader can only read files with version 1.1 or greater.
	/// Older versions can be converted to the newer versions using
	/// vtkXMLHierarchicalBoxDataFileConverter.
	/// </remarks>
	// Token: 0x020006C9 RID: 1737
	public class vtkXMLUniformGridAMRReader : vtkXMLCompositeDataReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060127C7 RID: 75719 RVA: 0x0019E963 File Offset: 0x0019CB63
		static vtkXMLUniformGridAMRReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLUniformGridAMRReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLUniformGridAMRReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060127C8 RID: 75720 RVA: 0x0019E98B File Offset: 0x0019CB8B
		public vtkXMLUniformGridAMRReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060127C9 RID: 75721
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLUniformGridAMRReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060127CA RID: 75722 RVA: 0x0019E99C File Offset: 0x0019CB9C
		public new static vtkXMLUniformGridAMRReader New()
		{
			vtkXMLUniformGridAMRReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLUniformGridAMRReader.vtkXMLUniformGridAMRReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLUniformGridAMRReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060127CB RID: 75723 RVA: 0x0019E9F0 File Offset: 0x0019CBF0
		public vtkXMLUniformGridAMRReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkXMLUniformGridAMRReader.vtkXMLUniformGridAMRReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060127CC RID: 75724 RVA: 0x0019EA34 File Offset: 0x0019CC34
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060127CD RID: 75725
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkXMLUniformGridAMRReader_GetMaximumLevelsToReadByDefault_01(HandleRef pThis);

		/// <summary>
		/// This reader supports demand-driven heavy data reading i.e. downstream
		/// pipeline can request specific blocks from the AMR using
		/// vtkCompositeDataPipeline::UPDATE_COMPOSITE_INDICES() key in
		/// RequestUpdateExtent() pass. However, when down-stream doesn't provide any
		/// specific keys, the default behavior can be setup to read at-most N levels
		/// by default. The number of levels read can be set using this method.
		/// Set this to 0 to imply no limit. Default is 0.
		/// </summary>
		// Token: 0x060127CE RID: 75726 RVA: 0x0019EA40 File Offset: 0x0019CC40
		public virtual uint GetMaximumLevelsToReadByDefault()
		{
			return vtkXMLUniformGridAMRReader.vtkXMLUniformGridAMRReader_GetMaximumLevelsToReadByDefault_01(base.GetCppThis());
		}

		// Token: 0x060127CF RID: 75727
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLUniformGridAMRReader_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060127D0 RID: 75728 RVA: 0x0019EA60 File Offset: 0x0019CC60
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLUniformGridAMRReader.vtkXMLUniformGridAMRReader_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x060127D1 RID: 75729
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLUniformGridAMRReader_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060127D2 RID: 75730 RVA: 0x0019EA80 File Offset: 0x0019CC80
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLUniformGridAMRReader.vtkXMLUniformGridAMRReader_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x060127D3 RID: 75731
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLUniformGridAMRReader_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060127D4 RID: 75732 RVA: 0x0019EA9C File Offset: 0x0019CC9C
		public override int IsA(string type)
		{
			return vtkXMLUniformGridAMRReader.vtkXMLUniformGridAMRReader_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x060127D5 RID: 75733
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLUniformGridAMRReader_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060127D6 RID: 75734 RVA: 0x0019EABC File Offset: 0x0019CCBC
		public new static int IsTypeOf(string type)
		{
			return vtkXMLUniformGridAMRReader.vtkXMLUniformGridAMRReader_IsTypeOf_05(type);
		}

		// Token: 0x060127D7 RID: 75735
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLUniformGridAMRReader_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060127D8 RID: 75736 RVA: 0x0019EAD8 File Offset: 0x0019CCD8
		public new vtkXMLUniformGridAMRReader NewInstance()
		{
			vtkXMLUniformGridAMRReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLUniformGridAMRReader.vtkXMLUniformGridAMRReader_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLUniformGridAMRReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060127D9 RID: 75737
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLUniformGridAMRReader_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060127DA RID: 75738 RVA: 0x0019EB34 File Offset: 0x0019CD34
		public new static vtkXMLUniformGridAMRReader SafeDownCast(vtkObjectBase o)
		{
			vtkXMLUniformGridAMRReader vtkXMLUniformGridAMRReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLUniformGridAMRReader.vtkXMLUniformGridAMRReader_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLUniformGridAMRReader = (vtkXMLUniformGridAMRReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLUniformGridAMRReader.Register(null);
				}
			}
			return vtkXMLUniformGridAMRReader;
		}

		// Token: 0x060127DB RID: 75739
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLUniformGridAMRReader_SetMaximumLevelsToReadByDefault_09(HandleRef pThis, uint _arg);

		/// <summary>
		/// This reader supports demand-driven heavy data reading i.e. downstream
		/// pipeline can request specific blocks from the AMR using
		/// vtkCompositeDataPipeline::UPDATE_COMPOSITE_INDICES() key in
		/// RequestUpdateExtent() pass. However, when down-stream doesn't provide any
		/// specific keys, the default behavior can be setup to read at-most N levels
		/// by default. The number of levels read can be set using this method.
		/// Set this to 0 to imply no limit. Default is 0.
		/// </summary>
		// Token: 0x060127DC RID: 75740 RVA: 0x0019EBB3 File Offset: 0x0019CDB3
		public virtual void SetMaximumLevelsToReadByDefault(uint _arg)
		{
			vtkXMLUniformGridAMRReader.vtkXMLUniformGridAMRReader_SetMaximumLevelsToReadByDefault_09(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001543 RID: 5443
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLUniformGridAMRReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001544 RID: 5444
		public new static readonly string MRClassNameKey = "class vtkXMLUniformGridAMRReader";
	}
}
