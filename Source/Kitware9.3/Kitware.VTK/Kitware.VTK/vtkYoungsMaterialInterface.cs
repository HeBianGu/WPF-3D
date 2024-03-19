using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkYoungsMaterialInterface
	/// </summary>
	/// <remarks>
	///    reconstructs material interfaces
	///
	///
	/// Reconstructs material interfaces from a mesh containing mixed cells (where several materials are
	/// mixed) this implementation is based on the youngs algorithm, generalized to arbitrary cell types
	/// and works on both 2D and 3D meshes. the main advantage of the youngs algorithm is it guarantees
	/// the material volume correctness. for 2D meshes, the AxisSymetric flag allows to switch between a
	/// pure 2D (planar) algorithm and an axis symmetric 2D algorithm handling volumes of revolution.
	///
	/// @par Thanks:
	/// This file is part of the generalized Youngs material interface reconstruction algorithm
	/// contributed by &lt;br&gt; CEA/DIF - Commissariat a l'Energie Atomique, Centre DAM Ile-De-France &lt;br&gt;
	/// BP12, F-91297 Arpajon, France. &lt;br&gt;
	/// Implementation by Thierry Carrard (thierry.carrard@cea.fr)
	/// Modification by Philippe Pebay (philippe.pebay@kitware.com)
	/// </remarks>
	// Token: 0x02000536 RID: 1334
	public class vtkYoungsMaterialInterface : vtkMultiBlockDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600EE01 RID: 60929 RVA: 0x0014BC3B File Offset: 0x00149E3B
		static vtkYoungsMaterialInterface()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkYoungsMaterialInterface.MRClassNameKey, Type.GetType("Kitware.VTK.vtkYoungsMaterialInterface"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600EE02 RID: 60930 RVA: 0x0014BC63 File Offset: 0x00149E63
		public vtkYoungsMaterialInterface(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600EE03 RID: 60931
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkYoungsMaterialInterface_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EE04 RID: 60932 RVA: 0x0014BC74 File Offset: 0x00149E74
		public new static vtkYoungsMaterialInterface New()
		{
			vtkYoungsMaterialInterface result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkYoungsMaterialInterface)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EE05 RID: 60933 RVA: 0x0014BCC8 File Offset: 0x00149EC8
		public vtkYoungsMaterialInterface() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600EE06 RID: 60934 RVA: 0x0014BD0C File Offset: 0x00149F0C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600EE07 RID: 60935
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkYoungsMaterialInterface_AddMaterialBlockMapping_01(HandleRef pThis, int b);

		/// <summary>
		/// select blocks to be processed for each described material.
		/// </summary>
		// Token: 0x0600EE08 RID: 60936 RVA: 0x0014BD17 File Offset: 0x00149F17
		public virtual void AddMaterialBlockMapping(int b)
		{
			vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_AddMaterialBlockMapping_01(base.GetCppThis(), b);
		}

		// Token: 0x0600EE09 RID: 60937
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkYoungsMaterialInterface_AxisSymetricOff_02(HandleRef pThis);

		/// <summary>
		/// Turns on/off AxisSymetric computation of 2D interfaces.
		/// in axis symmetric mode, 2D meshes are understood as volumes of revolution.
		/// </summary>
		// Token: 0x0600EE0A RID: 60938 RVA: 0x0014BD27 File Offset: 0x00149F27
		public virtual void AxisSymetricOff()
		{
			vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_AxisSymetricOff_02(base.GetCppThis());
		}

		// Token: 0x0600EE0B RID: 60939
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkYoungsMaterialInterface_AxisSymetricOn_03(HandleRef pThis);

		/// <summary>
		/// Turns on/off AxisSymetric computation of 2D interfaces.
		/// in axis symmetric mode, 2D meshes are understood as volumes of revolution.
		/// </summary>
		// Token: 0x0600EE0C RID: 60940 RVA: 0x0014BD36 File Offset: 0x00149F36
		public virtual void AxisSymetricOn()
		{
			vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_AxisSymetricOn_03(base.GetCppThis());
		}

		// Token: 0x0600EE0D RID: 60941
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkYoungsMaterialInterface_FillMaterialOff_04(HandleRef pThis);

		/// <summary>
		/// When FillMaterial is set to 1, the volume containing material is output and not only the
		/// interface surface.
		/// </summary>
		// Token: 0x0600EE0E RID: 60942 RVA: 0x0014BD45 File Offset: 0x00149F45
		public virtual void FillMaterialOff()
		{
			vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_FillMaterialOff_04(base.GetCppThis());
		}

		// Token: 0x0600EE0F RID: 60943
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkYoungsMaterialInterface_FillMaterialOn_05(HandleRef pThis);

		/// <summary>
		/// When FillMaterial is set to 1, the volume containing material is output and not only the
		/// interface surface.
		/// </summary>
		// Token: 0x0600EE10 RID: 60944 RVA: 0x0014BD54 File Offset: 0x00149F54
		public virtual void FillMaterialOn()
		{
			vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_FillMaterialOn_05(base.GetCppThis());
		}

		// Token: 0x0600EE11 RID: 60945
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkYoungsMaterialInterface_GetAxisSymetric_06(HandleRef pThis);

		/// <summary>
		/// Turns on/off AxisSymetric computation of 2D interfaces.
		/// in axis symmetric mode, 2D meshes are understood as volumes of revolution.
		/// </summary>
		// Token: 0x0600EE12 RID: 60946 RVA: 0x0014BD64 File Offset: 0x00149F64
		public virtual int GetAxisSymetric()
		{
			return vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_GetAxisSymetric_06(base.GetCppThis());
		}

		// Token: 0x0600EE13 RID: 60947
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkYoungsMaterialInterface_GetFillMaterial_07(HandleRef pThis);

		/// <summary>
		/// When FillMaterial is set to 1, the volume containing material is output and not only the
		/// interface surface.
		/// </summary>
		// Token: 0x0600EE14 RID: 60948 RVA: 0x0014BD84 File Offset: 0x00149F84
		public virtual int GetFillMaterial()
		{
			return vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_GetFillMaterial_07(base.GetCppThis());
		}

		// Token: 0x0600EE15 RID: 60949
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkYoungsMaterialInterface_GetInverseNormal_08(HandleRef pThis);

		/// <summary>
		/// Set/Get whether the normal vector has to be flipped.
		/// </summary>
		// Token: 0x0600EE16 RID: 60950 RVA: 0x0014BDA4 File Offset: 0x00149FA4
		public virtual int GetInverseNormal()
		{
			return vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_GetInverseNormal_08(base.GetCppThis());
		}

		// Token: 0x0600EE17 RID: 60951
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkYoungsMaterialInterface_GetNumberOfDomains_09(HandleRef pThis);

		/// <summary>
		/// Only meaningful for LOVE software. returns the maximum number of blocks containing the same
		/// material
		/// </summary>
		// Token: 0x0600EE18 RID: 60952 RVA: 0x0014BDC4 File Offset: 0x00149FC4
		public virtual int GetNumberOfDomains()
		{
			return vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_GetNumberOfDomains_09(base.GetCppThis());
		}

		// Token: 0x0600EE19 RID: 60953
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkYoungsMaterialInterface_GetNumberOfGenerationsFromBase_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EE1A RID: 60954 RVA: 0x0014BDE4 File Offset: 0x00149FE4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_GetNumberOfGenerationsFromBase_10(base.GetCppThis(), type);
		}

		// Token: 0x0600EE1B RID: 60955
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkYoungsMaterialInterface_GetNumberOfGenerationsFromBaseType_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EE1C RID: 60956 RVA: 0x0014BE04 File Offset: 0x0014A004
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_GetNumberOfGenerationsFromBaseType_11(type);
		}

		// Token: 0x0600EE1D RID: 60957
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkYoungsMaterialInterface_GetNumberOfMaterials_12(HandleRef pThis);

		/// <summary>
		/// Sets/Gets the number of materials.
		/// </summary>
		// Token: 0x0600EE1E RID: 60958 RVA: 0x0014BE20 File Offset: 0x0014A020
		public virtual int GetNumberOfMaterials()
		{
			return vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_GetNumberOfMaterials_12(base.GetCppThis());
		}

		// Token: 0x0600EE1F RID: 60959
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkYoungsMaterialInterface_GetOnionPeel_13(HandleRef pThis);

		/// <summary>
		/// Set/Get OnionPeel flag. if this flag is on, the normal vector of the first
		/// material (which depends on material ordering) is used for all materials.
		/// </summary>
		// Token: 0x0600EE20 RID: 60960 RVA: 0x0014BE40 File Offset: 0x0014A040
		public virtual int GetOnionPeel()
		{
			return vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_GetOnionPeel_13(base.GetCppThis());
		}

		// Token: 0x0600EE21 RID: 60961
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkYoungsMaterialInterface_GetReverseMaterialOrder_14(HandleRef pThis);

		/// <summary>
		/// If this flag is on, material order in reversed.
		/// Otherwise, materials are sorted in ascending order depending on the given ordering array.
		/// </summary>
		// Token: 0x0600EE22 RID: 60962 RVA: 0x0014BE60 File Offset: 0x0014A060
		public virtual int GetReverseMaterialOrder()
		{
			return vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_GetReverseMaterialOrder_14(base.GetCppThis());
		}

		// Token: 0x0600EE23 RID: 60963
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkYoungsMaterialInterface_GetUseAllBlocks_15(HandleRef pThis);

		/// <summary>
		/// Set/Get whether all material blocks should be used, irrespective of the material block mapping.
		/// </summary>
		// Token: 0x0600EE24 RID: 60964 RVA: 0x0014BE80 File Offset: 0x0014A080
		public virtual bool GetUseAllBlocks()
		{
			return vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_GetUseAllBlocks_15(base.GetCppThis()) != 0;
		}

		// Token: 0x0600EE25 RID: 60965
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkYoungsMaterialInterface_GetUseFractionAsDistance_16(HandleRef pThis);

		/// <summary>
		/// when UseFractionAsDistance is true, the volume fraction is interpreted as the distance
		/// of the cutting plane from the origin.
		/// in axis symmetric mode, 2D meshes are understood as volumes of revolution.
		/// </summary>
		// Token: 0x0600EE26 RID: 60966 RVA: 0x0014BEA8 File Offset: 0x0014A0A8
		public virtual int GetUseFractionAsDistance()
		{
			return vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_GetUseFractionAsDistance_16(base.GetCppThis());
		}

		// Token: 0x0600EE27 RID: 60967
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkYoungsMaterialInterface_GetVolumeFractionRange_17(HandleRef pThis);

		/// <summary>
		/// Set/Get minimum and maximum volume fraction value. if a material fills a volume above the
		/// minimum value, the material is considered to be void. if a material fills a volume fraction
		/// beyond the maximum value it is considered as filling the whole volume.
		/// </summary>
		// Token: 0x0600EE28 RID: 60968 RVA: 0x0014BEC8 File Offset: 0x0014A0C8
		public virtual double[] GetVolumeFractionRange()
		{
			IntPtr intPtr = vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_GetVolumeFractionRange_17(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600EE29 RID: 60969
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkYoungsMaterialInterface_GetVolumeFractionRange_18(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set/Get minimum and maximum volume fraction value. if a material fills a volume above the
		/// minimum value, the material is considered to be void. if a material fills a volume fraction
		/// beyond the maximum value it is considered as filling the whole volume.
		/// </summary>
		// Token: 0x0600EE2A RID: 60970 RVA: 0x0014BF10 File Offset: 0x0014A110
		public virtual void GetVolumeFractionRange(IntPtr data)
		{
			vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_GetVolumeFractionRange_18(base.GetCppThis(), data);
		}

		// Token: 0x0600EE2B RID: 60971
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkYoungsMaterialInterface_InverseNormalOff_19(HandleRef pThis);

		/// <summary>
		/// Set/Get whether the normal vector has to be flipped.
		/// </summary>
		// Token: 0x0600EE2C RID: 60972 RVA: 0x0014BF20 File Offset: 0x0014A120
		public virtual void InverseNormalOff()
		{
			vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_InverseNormalOff_19(base.GetCppThis());
		}

		// Token: 0x0600EE2D RID: 60973
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkYoungsMaterialInterface_InverseNormalOn_20(HandleRef pThis);

		/// <summary>
		/// Set/Get whether the normal vector has to be flipped.
		/// </summary>
		// Token: 0x0600EE2E RID: 60974 RVA: 0x0014BF2F File Offset: 0x0014A12F
		public virtual void InverseNormalOn()
		{
			vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_InverseNormalOn_20(base.GetCppThis());
		}

		// Token: 0x0600EE2F RID: 60975
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkYoungsMaterialInterface_IsA_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EE30 RID: 60976 RVA: 0x0014BF40 File Offset: 0x0014A140
		public override int IsA(string type)
		{
			return vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_IsA_21(base.GetCppThis(), type);
		}

		// Token: 0x0600EE31 RID: 60977
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkYoungsMaterialInterface_IsTypeOf_22([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EE32 RID: 60978 RVA: 0x0014BF60 File Offset: 0x0014A160
		public new static int IsTypeOf(string type)
		{
			return vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_IsTypeOf_22(type);
		}

		// Token: 0x0600EE33 RID: 60979
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkYoungsMaterialInterface_NewInstance_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EE34 RID: 60980 RVA: 0x0014BF7C File Offset: 0x0014A17C
		public new vtkYoungsMaterialInterface NewInstance()
		{
			vtkYoungsMaterialInterface result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_NewInstance_24(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkYoungsMaterialInterface)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600EE35 RID: 60981
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkYoungsMaterialInterface_OnionPeelOff_25(HandleRef pThis);

		/// <summary>
		/// Set/Get OnionPeel flag. if this flag is on, the normal vector of the first
		/// material (which depends on material ordering) is used for all materials.
		/// </summary>
		// Token: 0x0600EE36 RID: 60982 RVA: 0x0014BFD6 File Offset: 0x0014A1D6
		public virtual void OnionPeelOff()
		{
			vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_OnionPeelOff_25(base.GetCppThis());
		}

		// Token: 0x0600EE37 RID: 60983
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkYoungsMaterialInterface_OnionPeelOn_26(HandleRef pThis);

		/// <summary>
		/// Set/Get OnionPeel flag. if this flag is on, the normal vector of the first
		/// material (which depends on material ordering) is used for all materials.
		/// </summary>
		// Token: 0x0600EE38 RID: 60984 RVA: 0x0014BFE5 File Offset: 0x0014A1E5
		public virtual void OnionPeelOn()
		{
			vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_OnionPeelOn_26(base.GetCppThis());
		}

		// Token: 0x0600EE39 RID: 60985
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkYoungsMaterialInterface_RemoveAllMaterialBlockMappings_27(HandleRef pThis);

		/// <summary>
		/// select blocks to be processed for each described material.
		/// </summary>
		// Token: 0x0600EE3A RID: 60986 RVA: 0x0014BFF4 File Offset: 0x0014A1F4
		public virtual void RemoveAllMaterialBlockMappings()
		{
			vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_RemoveAllMaterialBlockMappings_27(base.GetCppThis());
		}

		// Token: 0x0600EE3B RID: 60987
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkYoungsMaterialInterface_RemoveAllMaterials_28(HandleRef pThis);

		/// <summary>
		/// Removes all materials previously added.
		/// </summary>
		// Token: 0x0600EE3C RID: 60988 RVA: 0x0014C003 File Offset: 0x0014A203
		public virtual void RemoveAllMaterials()
		{
			vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_RemoveAllMaterials_28(base.GetCppThis());
		}

		// Token: 0x0600EE3D RID: 60989
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkYoungsMaterialInterface_ReverseMaterialOrderOff_29(HandleRef pThis);

		/// <summary>
		/// If this flag is on, material order in reversed.
		/// Otherwise, materials are sorted in ascending order depending on the given ordering array.
		/// </summary>
		// Token: 0x0600EE3E RID: 60990 RVA: 0x0014C012 File Offset: 0x0014A212
		public virtual void ReverseMaterialOrderOff()
		{
			vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_ReverseMaterialOrderOff_29(base.GetCppThis());
		}

		// Token: 0x0600EE3F RID: 60991
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkYoungsMaterialInterface_ReverseMaterialOrderOn_30(HandleRef pThis);

		/// <summary>
		/// If this flag is on, material order in reversed.
		/// Otherwise, materials are sorted in ascending order depending on the given ordering array.
		/// </summary>
		// Token: 0x0600EE40 RID: 60992 RVA: 0x0014C021 File Offset: 0x0014A221
		public virtual void ReverseMaterialOrderOn()
		{
			vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_ReverseMaterialOrderOn_30(base.GetCppThis());
		}

		// Token: 0x0600EE41 RID: 60993
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkYoungsMaterialInterface_SafeDownCast_31(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EE42 RID: 60994 RVA: 0x0014C030 File Offset: 0x0014A230
		public new static vtkYoungsMaterialInterface SafeDownCast(vtkObjectBase o)
		{
			vtkYoungsMaterialInterface vtkYoungsMaterialInterface = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_SafeDownCast_31((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkYoungsMaterialInterface = (vtkYoungsMaterialInterface)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkYoungsMaterialInterface.Register(null);
				}
			}
			return vtkYoungsMaterialInterface;
		}

		// Token: 0x0600EE43 RID: 60995
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkYoungsMaterialInterface_SetAxisSymetric_32(HandleRef pThis, int _arg);

		/// <summary>
		/// Turns on/off AxisSymetric computation of 2D interfaces.
		/// in axis symmetric mode, 2D meshes are understood as volumes of revolution.
		/// </summary>
		// Token: 0x0600EE44 RID: 60996 RVA: 0x0014C0AF File Offset: 0x0014A2AF
		public virtual void SetAxisSymetric(int _arg)
		{
			vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_SetAxisSymetric_32(base.GetCppThis(), _arg);
		}

		// Token: 0x0600EE45 RID: 60997
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkYoungsMaterialInterface_SetFillMaterial_33(HandleRef pThis, int _arg);

		/// <summary>
		/// When FillMaterial is set to 1, the volume containing material is output and not only the
		/// interface surface.
		/// </summary>
		// Token: 0x0600EE46 RID: 60998 RVA: 0x0014C0BF File Offset: 0x0014A2BF
		public virtual void SetFillMaterial(int _arg)
		{
			vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_SetFillMaterial_33(base.GetCppThis(), _arg);
		}

		// Token: 0x0600EE47 RID: 60999
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkYoungsMaterialInterface_SetInverseNormal_34(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get whether the normal vector has to be flipped.
		/// </summary>
		// Token: 0x0600EE48 RID: 61000 RVA: 0x0014C0CF File Offset: 0x0014A2CF
		public virtual void SetInverseNormal(int _arg)
		{
			vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_SetInverseNormal_34(base.GetCppThis(), _arg);
		}

		// Token: 0x0600EE49 RID: 61001
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkYoungsMaterialInterface_SetMaterialArrays_35(HandleRef pThis, int i, [MarshalAs(UnmanagedType.LPUTF8Str)] string volume, [MarshalAs(UnmanagedType.LPUTF8Str)] string normalX, [MarshalAs(UnmanagedType.LPUTF8Str)] string normalY, [MarshalAs(UnmanagedType.LPUTF8Str)] string normalZ, [MarshalAs(UnmanagedType.LPUTF8Str)] string ordering);

		/// <summary>
		/// Set ith Material arrays to be used as volume fraction, interface normal and material ordering.
		/// Each parameter name a cell array.
		/// </summary>
		// Token: 0x0600EE4A RID: 61002 RVA: 0x0014C0DF File Offset: 0x0014A2DF
		public virtual void SetMaterialArrays(int i, string volume, string normalX, string normalY, string normalZ, string ordering)
		{
			vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_SetMaterialArrays_35(base.GetCppThis(), i, volume, normalX, normalY, normalZ, ordering);
		}

		// Token: 0x0600EE4B RID: 61003
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkYoungsMaterialInterface_SetMaterialArrays_36(HandleRef pThis, int i, [MarshalAs(UnmanagedType.LPUTF8Str)] string volume, [MarshalAs(UnmanagedType.LPUTF8Str)] string normal, [MarshalAs(UnmanagedType.LPUTF8Str)] string ordering);

		/// <summary>
		/// Set ith Material arrays to be used as volume fraction, interface normal and material ordering.
		/// Each parameter name a cell array.
		/// </summary>
		// Token: 0x0600EE4C RID: 61004 RVA: 0x0014C0F7 File Offset: 0x0014A2F7
		public virtual void SetMaterialArrays(int i, string volume, string normal, string ordering)
		{
			vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_SetMaterialArrays_36(base.GetCppThis(), i, volume, normal, ordering);
		}

		// Token: 0x0600EE4D RID: 61005
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkYoungsMaterialInterface_SetMaterialNormalArray_37(HandleRef pThis, int i, [MarshalAs(UnmanagedType.LPUTF8Str)] string normal);

		/// <summary>
		/// Set ith Material arrays to be used as volume fraction, interface normal and material ordering.
		/// Each parameter name a cell array.
		/// </summary>
		// Token: 0x0600EE4E RID: 61006 RVA: 0x0014C10B File Offset: 0x0014A30B
		public virtual void SetMaterialNormalArray(int i, string normal)
		{
			vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_SetMaterialNormalArray_37(base.GetCppThis(), i, normal);
		}

		// Token: 0x0600EE4F RID: 61007
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkYoungsMaterialInterface_SetMaterialNormalArray_38(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string volume, [MarshalAs(UnmanagedType.LPUTF8Str)] string normal);

		/// <summary>
		/// Alternative API for associating Normal and Ordering arrays to materials
		/// identified by its volume-fraction array.
		/// Note that these mappings are cleared by a call to RemoveAllMaterials() but
		/// not by SetNumberOfMaterials().
		/// If one uses the SetMaterial*Array(int, ...) API to set the normal or
		/// ordering arrays, then that supersedes the values set using this API.
		/// </summary>
		// Token: 0x0600EE50 RID: 61008 RVA: 0x0014C11C File Offset: 0x0014A31C
		public virtual void SetMaterialNormalArray(string volume, string normal)
		{
			vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_SetMaterialNormalArray_38(base.GetCppThis(), volume, normal);
		}

		// Token: 0x0600EE51 RID: 61009
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkYoungsMaterialInterface_SetMaterialOrderingArray_39(HandleRef pThis, int i, [MarshalAs(UnmanagedType.LPUTF8Str)] string ordering);

		/// <summary>
		/// Set ith Material arrays to be used as volume fraction, interface normal and material ordering.
		/// Each parameter name a cell array.
		/// </summary>
		// Token: 0x0600EE52 RID: 61010 RVA: 0x0014C12D File Offset: 0x0014A32D
		public virtual void SetMaterialOrderingArray(int i, string ordering)
		{
			vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_SetMaterialOrderingArray_39(base.GetCppThis(), i, ordering);
		}

		// Token: 0x0600EE53 RID: 61011
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkYoungsMaterialInterface_SetMaterialOrderingArray_40(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string volume, [MarshalAs(UnmanagedType.LPUTF8Str)] string ordering);

		/// <summary>
		/// Alternative API for associating Normal and Ordering arrays to materials
		/// identified by its volume-fraction array.
		/// Note that these mappings are cleared by a call to RemoveAllMaterials() but
		/// not by SetNumberOfMaterials().
		/// If one uses the SetMaterial*Array(int, ...) API to set the normal or
		/// ordering arrays, then that supersedes the values set using this API.
		/// </summary>
		// Token: 0x0600EE54 RID: 61012 RVA: 0x0014C13E File Offset: 0x0014A33E
		public virtual void SetMaterialOrderingArray(string volume, string ordering)
		{
			vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_SetMaterialOrderingArray_40(base.GetCppThis(), volume, ordering);
		}

		// Token: 0x0600EE55 RID: 61013
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkYoungsMaterialInterface_SetMaterialVolumeFractionArray_41(HandleRef pThis, int i, [MarshalAs(UnmanagedType.LPUTF8Str)] string volume);

		/// <summary>
		/// Set ith Material arrays to be used as volume fraction, interface normal and material ordering.
		/// Each parameter name a cell array.
		/// </summary>
		// Token: 0x0600EE56 RID: 61014 RVA: 0x0014C14F File Offset: 0x0014A34F
		public virtual void SetMaterialVolumeFractionArray(int i, string volume)
		{
			vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_SetMaterialVolumeFractionArray_41(base.GetCppThis(), i, volume);
		}

		// Token: 0x0600EE57 RID: 61015
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkYoungsMaterialInterface_SetNumberOfMaterials_42(HandleRef pThis, int n);

		/// <summary>
		/// Sets/Gets the number of materials.
		/// </summary>
		// Token: 0x0600EE58 RID: 61016 RVA: 0x0014C160 File Offset: 0x0014A360
		public virtual void SetNumberOfMaterials(int n)
		{
			vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_SetNumberOfMaterials_42(base.GetCppThis(), n);
		}

		// Token: 0x0600EE59 RID: 61017
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkYoungsMaterialInterface_SetOnionPeel_43(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get OnionPeel flag. if this flag is on, the normal vector of the first
		/// material (which depends on material ordering) is used for all materials.
		/// </summary>
		// Token: 0x0600EE5A RID: 61018 RVA: 0x0014C170 File Offset: 0x0014A370
		public virtual void SetOnionPeel(int _arg)
		{
			vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_SetOnionPeel_43(base.GetCppThis(), _arg);
		}

		// Token: 0x0600EE5B RID: 61019
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkYoungsMaterialInterface_SetReverseMaterialOrder_44(HandleRef pThis, int _arg);

		/// <summary>
		/// If this flag is on, material order in reversed.
		/// Otherwise, materials are sorted in ascending order depending on the given ordering array.
		/// </summary>
		// Token: 0x0600EE5C RID: 61020 RVA: 0x0014C180 File Offset: 0x0014A380
		public virtual void SetReverseMaterialOrder(int _arg)
		{
			vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_SetReverseMaterialOrder_44(base.GetCppThis(), _arg);
		}

		// Token: 0x0600EE5D RID: 61021
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkYoungsMaterialInterface_SetUseAllBlocks_45(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get whether all material blocks should be used, irrespective of the material block mapping.
		/// </summary>
		// Token: 0x0600EE5E RID: 61022 RVA: 0x0014C190 File Offset: 0x0014A390
		public virtual void SetUseAllBlocks(bool _arg)
		{
			vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_SetUseAllBlocks_45(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600EE5F RID: 61023
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkYoungsMaterialInterface_SetUseFractionAsDistance_46(HandleRef pThis, int _arg);

		/// <summary>
		/// when UseFractionAsDistance is true, the volume fraction is interpreted as the distance
		/// of the cutting plane from the origin.
		/// in axis symmetric mode, 2D meshes are understood as volumes of revolution.
		/// </summary>
		// Token: 0x0600EE60 RID: 61024 RVA: 0x0014C1A8 File Offset: 0x0014A3A8
		public virtual void SetUseFractionAsDistance(int _arg)
		{
			vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_SetUseFractionAsDistance_46(base.GetCppThis(), _arg);
		}

		// Token: 0x0600EE61 RID: 61025
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkYoungsMaterialInterface_SetVolumeFractionRange_47(HandleRef pThis, double _arg1, double _arg2);

		/// <summary>
		/// Set/Get minimum and maximum volume fraction value. if a material fills a volume above the
		/// minimum value, the material is considered to be void. if a material fills a volume fraction
		/// beyond the maximum value it is considered as filling the whole volume.
		/// </summary>
		// Token: 0x0600EE62 RID: 61026 RVA: 0x0014C1B8 File Offset: 0x0014A3B8
		public virtual void SetVolumeFractionRange(double _arg1, double _arg2)
		{
			vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_SetVolumeFractionRange_47(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x0600EE63 RID: 61027
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkYoungsMaterialInterface_SetVolumeFractionRange_48(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get minimum and maximum volume fraction value. if a material fills a volume above the
		/// minimum value, the material is considered to be void. if a material fills a volume fraction
		/// beyond the maximum value it is considered as filling the whole volume.
		/// </summary>
		// Token: 0x0600EE64 RID: 61028 RVA: 0x0014C1C9 File Offset: 0x0014A3C9
		public void SetVolumeFractionRange(IntPtr _arg)
		{
			vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_SetVolumeFractionRange_48(base.GetCppThis(), _arg);
		}

		// Token: 0x0600EE65 RID: 61029
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkYoungsMaterialInterface_UseAllBlocksOff_49(HandleRef pThis);

		/// <summary>
		/// Set/Get whether all material blocks should be used, irrespective of the material block mapping.
		/// </summary>
		// Token: 0x0600EE66 RID: 61030 RVA: 0x0014C1D9 File Offset: 0x0014A3D9
		public virtual void UseAllBlocksOff()
		{
			vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_UseAllBlocksOff_49(base.GetCppThis());
		}

		// Token: 0x0600EE67 RID: 61031
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkYoungsMaterialInterface_UseAllBlocksOn_50(HandleRef pThis);

		/// <summary>
		/// Set/Get whether all material blocks should be used, irrespective of the material block mapping.
		/// </summary>
		// Token: 0x0600EE68 RID: 61032 RVA: 0x0014C1E8 File Offset: 0x0014A3E8
		public virtual void UseAllBlocksOn()
		{
			vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_UseAllBlocksOn_50(base.GetCppThis());
		}

		// Token: 0x0600EE69 RID: 61033
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkYoungsMaterialInterface_UseFractionAsDistanceOff_51(HandleRef pThis);

		/// <summary>
		/// when UseFractionAsDistance is true, the volume fraction is interpreted as the distance
		/// of the cutting plane from the origin.
		/// in axis symmetric mode, 2D meshes are understood as volumes of revolution.
		/// </summary>
		// Token: 0x0600EE6A RID: 61034 RVA: 0x0014C1F7 File Offset: 0x0014A3F7
		public virtual void UseFractionAsDistanceOff()
		{
			vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_UseFractionAsDistanceOff_51(base.GetCppThis());
		}

		// Token: 0x0600EE6B RID: 61035
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkYoungsMaterialInterface_UseFractionAsDistanceOn_52(HandleRef pThis);

		/// <summary>
		/// when UseFractionAsDistance is true, the volume fraction is interpreted as the distance
		/// of the cutting plane from the origin.
		/// in axis symmetric mode, 2D meshes are understood as volumes of revolution.
		/// </summary>
		// Token: 0x0600EE6C RID: 61036 RVA: 0x0014C206 File Offset: 0x0014A406
		public virtual void UseFractionAsDistanceOn()
		{
			vtkYoungsMaterialInterface.vtkYoungsMaterialInterface_UseFractionAsDistanceOn_52(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001164 RID: 4452
		public new const string MRFullTypeName = "Kitware.VTK.vtkYoungsMaterialInterface";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001165 RID: 4453
		public new static readonly string MRClassNameKey = "class vtkYoungsMaterialInterface";

		/// <summary>
		/// select blocks to be processed for each described material.
		/// </summary>
		// Token: 0x02000537 RID: 1335
		public enum MAX_CELL_POINTS_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04001167 RID: 4455
			MAX_CELL_POINTS = 256
		}
	}
}
