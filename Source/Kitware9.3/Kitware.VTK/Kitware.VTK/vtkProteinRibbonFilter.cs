using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkProteinRibbonFilter
	/// </summary>
	/// <remarks>
	///    generates protein ribbons
	///
	/// vtkProteinRibbonFilter is a polydata algorithm that generates protein
	/// ribbons.
	/// </remarks>
	// Token: 0x02000629 RID: 1577
	public class vtkProteinRibbonFilter : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06011134 RID: 69940 RVA: 0x0017CCA4 File Offset: 0x0017AEA4
		static vtkProteinRibbonFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkProteinRibbonFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkProteinRibbonFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06011135 RID: 69941 RVA: 0x0017CCCC File Offset: 0x0017AECC
		public vtkProteinRibbonFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06011136 RID: 69942
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProteinRibbonFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011137 RID: 69943 RVA: 0x0017CCDC File Offset: 0x0017AEDC
		public new static vtkProteinRibbonFilter New()
		{
			vtkProteinRibbonFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProteinRibbonFilter.vtkProteinRibbonFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProteinRibbonFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011138 RID: 69944 RVA: 0x0017CD30 File Offset: 0x0017AF30
		public vtkProteinRibbonFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkProteinRibbonFilter.vtkProteinRibbonFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06011139 RID: 69945 RVA: 0x0017CD74 File Offset: 0x0017AF74
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601113A RID: 69946
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkProteinRibbonFilter_GetCoilWidth_01(HandleRef pThis);

		/// <summary>
		/// Width of the ribbon coil. Default is 0.3.
		/// </summary>
		// Token: 0x0601113B RID: 69947 RVA: 0x0017CD80 File Offset: 0x0017AF80
		public virtual float GetCoilWidth()
		{
			return vtkProteinRibbonFilter.vtkProteinRibbonFilter_GetCoilWidth_01(base.GetCppThis());
		}

		// Token: 0x0601113C RID: 69948
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkProteinRibbonFilter_GetDrawSmallMoleculesAsSpheres_02(HandleRef pThis);

		/// <summary>
		/// If enabled, small molecules (HETATMs) are drawn as spheres. Default is true.
		/// </summary>
		// Token: 0x0601113D RID: 69949 RVA: 0x0017CDA0 File Offset: 0x0017AFA0
		public virtual bool GetDrawSmallMoleculesAsSpheres()
		{
			return vtkProteinRibbonFilter.vtkProteinRibbonFilter_GetDrawSmallMoleculesAsSpheres_02(base.GetCppThis()) != 0;
		}

		// Token: 0x0601113E RID: 69950
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkProteinRibbonFilter_GetHelixWidth_03(HandleRef pThis);

		/// <summary>
		/// Width of the helix part of the ribbon. Default is 1.3.
		/// </summary>
		// Token: 0x0601113F RID: 69951 RVA: 0x0017CDC8 File Offset: 0x0017AFC8
		public virtual float GetHelixWidth()
		{
			return vtkProteinRibbonFilter.vtkProteinRibbonFilter_GetHelixWidth_03(base.GetCppThis());
		}

		// Token: 0x06011140 RID: 69952
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProteinRibbonFilter_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011141 RID: 69953 RVA: 0x0017CDE8 File Offset: 0x0017AFE8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkProteinRibbonFilter.vtkProteinRibbonFilter_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06011142 RID: 69954
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProteinRibbonFilter_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011143 RID: 69955 RVA: 0x0017CE08 File Offset: 0x0017B008
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkProteinRibbonFilter.vtkProteinRibbonFilter_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06011144 RID: 69956
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProteinRibbonFilter_GetSphereResolution_06(HandleRef pThis);

		/// <summary>
		/// Resolution of the spheres for small molecules. Default is 20.
		/// </summary>
		// Token: 0x06011145 RID: 69957 RVA: 0x0017CE24 File Offset: 0x0017B024
		public virtual int GetSphereResolution()
		{
			return vtkProteinRibbonFilter.vtkProteinRibbonFilter_GetSphereResolution_06(base.GetCppThis());
		}

		// Token: 0x06011146 RID: 69958
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProteinRibbonFilter_GetSubdivideFactor_07(HandleRef pThis);

		/// <summary>
		/// Smoothing factor of the ribbon. Default is 20.
		/// </summary>
		// Token: 0x06011147 RID: 69959 RVA: 0x0017CE44 File Offset: 0x0017B044
		public virtual int GetSubdivideFactor()
		{
			return vtkProteinRibbonFilter.vtkProteinRibbonFilter_GetSubdivideFactor_07(base.GetCppThis());
		}

		// Token: 0x06011148 RID: 69960
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProteinRibbonFilter_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011149 RID: 69961 RVA: 0x0017CE64 File Offset: 0x0017B064
		public override int IsA(string type)
		{
			return vtkProteinRibbonFilter.vtkProteinRibbonFilter_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x0601114A RID: 69962
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProteinRibbonFilter_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601114B RID: 69963 RVA: 0x0017CE84 File Offset: 0x0017B084
		public new static int IsTypeOf(string type)
		{
			return vtkProteinRibbonFilter.vtkProteinRibbonFilter_IsTypeOf_09(type);
		}

		// Token: 0x0601114C RID: 69964
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProteinRibbonFilter_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601114D RID: 69965 RVA: 0x0017CEA0 File Offset: 0x0017B0A0
		public new vtkProteinRibbonFilter NewInstance()
		{
			vtkProteinRibbonFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProteinRibbonFilter.vtkProteinRibbonFilter_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProteinRibbonFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601114E RID: 69966
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProteinRibbonFilter_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601114F RID: 69967 RVA: 0x0017CEFC File Offset: 0x0017B0FC
		public new static vtkProteinRibbonFilter SafeDownCast(vtkObjectBase o)
		{
			vtkProteinRibbonFilter vtkProteinRibbonFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProteinRibbonFilter.vtkProteinRibbonFilter_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProteinRibbonFilter = (vtkProteinRibbonFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProteinRibbonFilter.Register(null);
				}
			}
			return vtkProteinRibbonFilter;
		}

		// Token: 0x06011150 RID: 69968
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProteinRibbonFilter_SetCoilWidth_13(HandleRef pThis, float _arg);

		/// <summary>
		/// Width of the ribbon coil. Default is 0.3.
		/// </summary>
		// Token: 0x06011151 RID: 69969 RVA: 0x0017CF7B File Offset: 0x0017B17B
		public virtual void SetCoilWidth(float _arg)
		{
			vtkProteinRibbonFilter.vtkProteinRibbonFilter_SetCoilWidth_13(base.GetCppThis(), _arg);
		}

		// Token: 0x06011152 RID: 69970
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProteinRibbonFilter_SetDrawSmallMoleculesAsSpheres_14(HandleRef pThis, byte _arg);

		/// <summary>
		/// If enabled, small molecules (HETATMs) are drawn as spheres. Default is true.
		/// </summary>
		// Token: 0x06011153 RID: 69971 RVA: 0x0017CF8B File Offset: 0x0017B18B
		public virtual void SetDrawSmallMoleculesAsSpheres(bool _arg)
		{
			vtkProteinRibbonFilter.vtkProteinRibbonFilter_SetDrawSmallMoleculesAsSpheres_14(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06011154 RID: 69972
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProteinRibbonFilter_SetHelixWidth_15(HandleRef pThis, float _arg);

		/// <summary>
		/// Width of the helix part of the ribbon. Default is 1.3.
		/// </summary>
		// Token: 0x06011155 RID: 69973 RVA: 0x0017CFA3 File Offset: 0x0017B1A3
		public virtual void SetHelixWidth(float _arg)
		{
			vtkProteinRibbonFilter.vtkProteinRibbonFilter_SetHelixWidth_15(base.GetCppThis(), _arg);
		}

		// Token: 0x06011156 RID: 69974
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProteinRibbonFilter_SetSphereResolution_16(HandleRef pThis, int _arg);

		/// <summary>
		/// Resolution of the spheres for small molecules. Default is 20.
		/// </summary>
		// Token: 0x06011157 RID: 69975 RVA: 0x0017CFB3 File Offset: 0x0017B1B3
		public virtual void SetSphereResolution(int _arg)
		{
			vtkProteinRibbonFilter.vtkProteinRibbonFilter_SetSphereResolution_16(base.GetCppThis(), _arg);
		}

		// Token: 0x06011158 RID: 69976
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProteinRibbonFilter_SetSubdivideFactor_17(HandleRef pThis, int _arg);

		/// <summary>
		/// Smoothing factor of the ribbon. Default is 20.
		/// </summary>
		// Token: 0x06011159 RID: 69977 RVA: 0x0017CFC3 File Offset: 0x0017B1C3
		public virtual void SetSubdivideFactor(int _arg)
		{
			vtkProteinRibbonFilter.vtkProteinRibbonFilter_SetSubdivideFactor_17(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040013B8 RID: 5048
		public new const string MRFullTypeName = "Kitware.VTK.vtkProteinRibbonFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040013B9 RID: 5049
		public new static readonly string MRClassNameKey = "class vtkProteinRibbonFilter";
	}
}
