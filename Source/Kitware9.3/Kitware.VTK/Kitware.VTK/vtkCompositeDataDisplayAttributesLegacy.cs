using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCompositeDataDisplayAttributesLegacy
	/// </summary>
	/// <remarks>
	///    rendering attributes for a
	/// multi-block dataset.
	///
	/// The vtkCompositeDataDisplayAttributesLegacy class stores display attributes
	/// for individual blocks in a multi-block dataset. Attributes are mapped to
	/// blocks through their flat-index; This is the mechanism used in legacy
	/// OpenGL classes.
	/// </remarks>
	// Token: 0x020007D5 RID: 2005
	public class vtkCompositeDataDisplayAttributesLegacy : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06014937 RID: 84279 RVA: 0x001D2064 File Offset: 0x001D0264
		static vtkCompositeDataDisplayAttributesLegacy()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCompositeDataDisplayAttributesLegacy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCompositeDataDisplayAttributesLegacy"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06014938 RID: 84280 RVA: 0x001D208C File Offset: 0x001D028C
		public vtkCompositeDataDisplayAttributesLegacy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06014939 RID: 84281
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeDataDisplayAttributesLegacy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601493A RID: 84282 RVA: 0x001D209C File Offset: 0x001D029C
		public new static vtkCompositeDataDisplayAttributesLegacy New()
		{
			vtkCompositeDataDisplayAttributesLegacy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeDataDisplayAttributesLegacy.vtkCompositeDataDisplayAttributesLegacy_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompositeDataDisplayAttributesLegacy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601493B RID: 84283 RVA: 0x001D20F0 File Offset: 0x001D02F0
		public vtkCompositeDataDisplayAttributesLegacy() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCompositeDataDisplayAttributesLegacy.vtkCompositeDataDisplayAttributesLegacy_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601493C RID: 84284 RVA: 0x001D2134 File Offset: 0x001D0334
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601493D RID: 84285
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataDisplayAttributesLegacy_ComputeVisibleBounds_01(HandleRef cda, HandleRef dobj, IntPtr bounds);

		/// <summary>
		/// Removes all block opacities.
		/// </summary>
		// Token: 0x0601493E RID: 84286 RVA: 0x001D2140 File Offset: 0x001D0340
		public static void ComputeVisibleBounds(vtkCompositeDataDisplayAttributesLegacy cda, vtkDataObject dobj, IntPtr bounds)
		{
			vtkCompositeDataDisplayAttributesLegacy.vtkCompositeDataDisplayAttributesLegacy_ComputeVisibleBounds_01((cda == null) ? default(HandleRef) : cda.GetCppThis(), (dobj == null) ? default(HandleRef) : dobj.GetCppThis(), bounds);
		}

		// Token: 0x0601493F RID: 84287
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataDisplayAttributesLegacy_GetBlockColor_02(HandleRef pThis, uint flat_index, IntPtr color);

		/// <summary>
		/// Set/get the color for the block with \p flat_index.
		/// </summary>
		// Token: 0x06014940 RID: 84288 RVA: 0x001D217F File Offset: 0x001D037F
		public void GetBlockColor(uint flat_index, IntPtr color)
		{
			vtkCompositeDataDisplayAttributesLegacy.vtkCompositeDataDisplayAttributesLegacy_GetBlockColor_02(base.GetCppThis(), flat_index, color);
		}

		// Token: 0x06014941 RID: 84289
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeDataDisplayAttributesLegacy_GetBlockColor_03(HandleRef pThis, uint flat_index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/get the color for the block with \p flat_index.
		/// </summary>
		// Token: 0x06014942 RID: 84290 RVA: 0x001D2190 File Offset: 0x001D0390
		public vtkColor3d GetBlockColor(uint flat_index)
		{
			vtkColor3d result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeDataDisplayAttributesLegacy.vtkCompositeDataDisplayAttributesLegacy_GetBlockColor_03(base.GetCppThis(), flat_index, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkColor3d)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06014943 RID: 84291
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCompositeDataDisplayAttributesLegacy_GetBlockOpacity_04(HandleRef pThis, uint flat_index);

		/// <summary>
		/// Set/get the opacity for the block with flat_index.
		/// </summary>
		// Token: 0x06014944 RID: 84292 RVA: 0x001D21EC File Offset: 0x001D03EC
		public double GetBlockOpacity(uint flat_index)
		{
			return vtkCompositeDataDisplayAttributesLegacy.vtkCompositeDataDisplayAttributesLegacy_GetBlockOpacity_04(base.GetCppThis(), flat_index);
		}

		// Token: 0x06014945 RID: 84293
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCompositeDataDisplayAttributesLegacy_GetBlockPickability_05(HandleRef pThis, uint flat_index);

		/// <summary>
		/// Set/get the visibility for the block with \p flat_index.
		/// </summary>
		// Token: 0x06014946 RID: 84294 RVA: 0x001D220C File Offset: 0x001D040C
		public bool GetBlockPickability(uint flat_index)
		{
			return vtkCompositeDataDisplayAttributesLegacy.vtkCompositeDataDisplayAttributesLegacy_GetBlockPickability_05(base.GetCppThis(), flat_index) != 0;
		}

		// Token: 0x06014947 RID: 84295
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCompositeDataDisplayAttributesLegacy_GetBlockVisibility_06(HandleRef pThis, uint flat_index);

		/// <summary>
		/// Set/get the visibility for the block with \p flat_index.
		/// </summary>
		// Token: 0x06014948 RID: 84296 RVA: 0x001D2234 File Offset: 0x001D0434
		public bool GetBlockVisibility(uint flat_index)
		{
			return vtkCompositeDataDisplayAttributesLegacy.vtkCompositeDataDisplayAttributesLegacy_GetBlockVisibility_06(base.GetCppThis(), flat_index) != 0;
		}

		// Token: 0x06014949 RID: 84297
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCompositeDataDisplayAttributesLegacy_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601494A RID: 84298 RVA: 0x001D225C File Offset: 0x001D045C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCompositeDataDisplayAttributesLegacy.vtkCompositeDataDisplayAttributesLegacy_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x0601494B RID: 84299
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCompositeDataDisplayAttributesLegacy_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601494C RID: 84300 RVA: 0x001D227C File Offset: 0x001D047C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCompositeDataDisplayAttributesLegacy.vtkCompositeDataDisplayAttributesLegacy_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x0601494D RID: 84301
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCompositeDataDisplayAttributesLegacy_HasBlockColor_09(HandleRef pThis, uint flat_index);

		/// <summary>
		/// Returns true if the block with the given \p flat_index has a color.
		/// </summary>
		// Token: 0x0601494E RID: 84302 RVA: 0x001D2298 File Offset: 0x001D0498
		public bool HasBlockColor(uint flat_index)
		{
			return vtkCompositeDataDisplayAttributesLegacy.vtkCompositeDataDisplayAttributesLegacy_HasBlockColor_09(base.GetCppThis(), flat_index) != 0;
		}

		// Token: 0x0601494F RID: 84303
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCompositeDataDisplayAttributesLegacy_HasBlockColors_10(HandleRef pThis);

		/// <summary>
		/// Returns true if any block has any block color is set.
		/// </summary>
		// Token: 0x06014950 RID: 84304 RVA: 0x001D22C0 File Offset: 0x001D04C0
		public bool HasBlockColors()
		{
			return vtkCompositeDataDisplayAttributesLegacy.vtkCompositeDataDisplayAttributesLegacy_HasBlockColors_10(base.GetCppThis()) != 0;
		}

		// Token: 0x06014951 RID: 84305
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCompositeDataDisplayAttributesLegacy_HasBlockOpacities_11(HandleRef pThis);

		/// <summary>
		/// Returns true if any block has an opacity set.
		/// </summary>
		// Token: 0x06014952 RID: 84306 RVA: 0x001D22E8 File Offset: 0x001D04E8
		public bool HasBlockOpacities()
		{
			return vtkCompositeDataDisplayAttributesLegacy.vtkCompositeDataDisplayAttributesLegacy_HasBlockOpacities_11(base.GetCppThis()) != 0;
		}

		// Token: 0x06014953 RID: 84307
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCompositeDataDisplayAttributesLegacy_HasBlockOpacity_12(HandleRef pThis, uint flat_index);

		/// <summary>
		/// Returns true if the block with flat_index has an opacity set.
		/// </summary>
		// Token: 0x06014954 RID: 84308 RVA: 0x001D2310 File Offset: 0x001D0510
		public bool HasBlockOpacity(uint flat_index)
		{
			return vtkCompositeDataDisplayAttributesLegacy.vtkCompositeDataDisplayAttributesLegacy_HasBlockOpacity_12(base.GetCppThis(), flat_index) != 0;
		}

		// Token: 0x06014955 RID: 84309
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCompositeDataDisplayAttributesLegacy_HasBlockPickabilities_13(HandleRef pThis);

		/// <summary>
		/// Returns true if any block has any block visibility is set.
		/// </summary>
		// Token: 0x06014956 RID: 84310 RVA: 0x001D2338 File Offset: 0x001D0538
		public bool HasBlockPickabilities()
		{
			return vtkCompositeDataDisplayAttributesLegacy.vtkCompositeDataDisplayAttributesLegacy_HasBlockPickabilities_13(base.GetCppThis()) != 0;
		}

		// Token: 0x06014957 RID: 84311
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCompositeDataDisplayAttributesLegacy_HasBlockPickability_14(HandleRef pThis, uint flat_index);

		/// <summary>
		/// Returns true if the block with the given flat_index has a visibility
		/// set.
		/// </summary>
		// Token: 0x06014958 RID: 84312 RVA: 0x001D2360 File Offset: 0x001D0560
		public bool HasBlockPickability(uint flat_index)
		{
			return vtkCompositeDataDisplayAttributesLegacy.vtkCompositeDataDisplayAttributesLegacy_HasBlockPickability_14(base.GetCppThis(), flat_index) != 0;
		}

		// Token: 0x06014959 RID: 84313
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCompositeDataDisplayAttributesLegacy_HasBlockVisibilities_15(HandleRef pThis);

		/// <summary>
		/// Returns true if any block has any block visibility is set.
		/// </summary>
		// Token: 0x0601495A RID: 84314 RVA: 0x001D2388 File Offset: 0x001D0588
		public bool HasBlockVisibilities()
		{
			return vtkCompositeDataDisplayAttributesLegacy.vtkCompositeDataDisplayAttributesLegacy_HasBlockVisibilities_15(base.GetCppThis()) != 0;
		}

		// Token: 0x0601495B RID: 84315
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCompositeDataDisplayAttributesLegacy_HasBlockVisibility_16(HandleRef pThis, uint flat_index);

		/// <summary>
		/// Returns true if the block with the given flat_index has a visibility
		/// set.
		/// </summary>
		// Token: 0x0601495C RID: 84316 RVA: 0x001D23B0 File Offset: 0x001D05B0
		public bool HasBlockVisibility(uint flat_index)
		{
			return vtkCompositeDataDisplayAttributesLegacy.vtkCompositeDataDisplayAttributesLegacy_HasBlockVisibility_16(base.GetCppThis(), flat_index) != 0;
		}

		// Token: 0x0601495D RID: 84317
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompositeDataDisplayAttributesLegacy_IsA_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601495E RID: 84318 RVA: 0x001D23D8 File Offset: 0x001D05D8
		public override int IsA(string type)
		{
			return vtkCompositeDataDisplayAttributesLegacy.vtkCompositeDataDisplayAttributesLegacy_IsA_17(base.GetCppThis(), type);
		}

		// Token: 0x0601495F RID: 84319
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompositeDataDisplayAttributesLegacy_IsTypeOf_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014960 RID: 84320 RVA: 0x001D23F8 File Offset: 0x001D05F8
		public new static int IsTypeOf(string type)
		{
			return vtkCompositeDataDisplayAttributesLegacy.vtkCompositeDataDisplayAttributesLegacy_IsTypeOf_18(type);
		}

		// Token: 0x06014961 RID: 84321
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeDataDisplayAttributesLegacy_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014962 RID: 84322 RVA: 0x001D2414 File Offset: 0x001D0614
		public new vtkCompositeDataDisplayAttributesLegacy NewInstance()
		{
			vtkCompositeDataDisplayAttributesLegacy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeDataDisplayAttributesLegacy.vtkCompositeDataDisplayAttributesLegacy_NewInstance_20(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompositeDataDisplayAttributesLegacy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06014963 RID: 84323
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataDisplayAttributesLegacy_RemoveBlockColor_21(HandleRef pThis, uint flat_index);

		/// <summary>
		/// Removes the block color for the block with \p flat_index.
		/// </summary>
		// Token: 0x06014964 RID: 84324 RVA: 0x001D246E File Offset: 0x001D066E
		public void RemoveBlockColor(uint flat_index)
		{
			vtkCompositeDataDisplayAttributesLegacy.vtkCompositeDataDisplayAttributesLegacy_RemoveBlockColor_21(base.GetCppThis(), flat_index);
		}

		// Token: 0x06014965 RID: 84325
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataDisplayAttributesLegacy_RemoveBlockColors_22(HandleRef pThis);

		/// <summary>
		/// Removes all block colors.
		/// </summary>
		// Token: 0x06014966 RID: 84326 RVA: 0x001D247E File Offset: 0x001D067E
		public void RemoveBlockColors()
		{
			vtkCompositeDataDisplayAttributesLegacy.vtkCompositeDataDisplayAttributesLegacy_RemoveBlockColors_22(base.GetCppThis());
		}

		// Token: 0x06014967 RID: 84327
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataDisplayAttributesLegacy_RemoveBlockOpacities_23(HandleRef pThis);

		/// <summary>
		/// Removes all block opacities.
		/// </summary>
		// Token: 0x06014968 RID: 84328 RVA: 0x001D248D File Offset: 0x001D068D
		public void RemoveBlockOpacities()
		{
			vtkCompositeDataDisplayAttributesLegacy.vtkCompositeDataDisplayAttributesLegacy_RemoveBlockOpacities_23(base.GetCppThis());
		}

		// Token: 0x06014969 RID: 84329
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataDisplayAttributesLegacy_RemoveBlockOpacity_24(HandleRef pThis, uint flat_index);

		/// <summary>
		/// Removes the set opacity for the block with flat_index.
		/// </summary>
		// Token: 0x0601496A RID: 84330 RVA: 0x001D249C File Offset: 0x001D069C
		public void RemoveBlockOpacity(uint flat_index)
		{
			vtkCompositeDataDisplayAttributesLegacy.vtkCompositeDataDisplayAttributesLegacy_RemoveBlockOpacity_24(base.GetCppThis(), flat_index);
		}

		// Token: 0x0601496B RID: 84331
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataDisplayAttributesLegacy_RemoveBlockPickabilities_25(HandleRef pThis);

		/// <summary>
		/// Removes all block visibility flags. The effectively sets the visibility
		/// for all blocks to true.
		/// </summary>
		// Token: 0x0601496C RID: 84332 RVA: 0x001D24AC File Offset: 0x001D06AC
		public void RemoveBlockPickabilities()
		{
			vtkCompositeDataDisplayAttributesLegacy.vtkCompositeDataDisplayAttributesLegacy_RemoveBlockPickabilities_25(base.GetCppThis());
		}

		// Token: 0x0601496D RID: 84333
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataDisplayAttributesLegacy_RemoveBlockPickability_26(HandleRef pThis, uint flat_index);

		/// <summary>
		/// Removes the block visibility flag for the block with flat_index.
		/// </summary>
		// Token: 0x0601496E RID: 84334 RVA: 0x001D24BB File Offset: 0x001D06BB
		public void RemoveBlockPickability(uint flat_index)
		{
			vtkCompositeDataDisplayAttributesLegacy.vtkCompositeDataDisplayAttributesLegacy_RemoveBlockPickability_26(base.GetCppThis(), flat_index);
		}

		// Token: 0x0601496F RID: 84335
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataDisplayAttributesLegacy_RemoveBlockVisibilities_27(HandleRef pThis);

		/// <summary>
		/// Removes all block visibility flags. The effectively sets the visibility
		/// for all blocks to true.
		/// </summary>
		// Token: 0x06014970 RID: 84336 RVA: 0x001D24CB File Offset: 0x001D06CB
		public void RemoveBlockVisibilities()
		{
			vtkCompositeDataDisplayAttributesLegacy.vtkCompositeDataDisplayAttributesLegacy_RemoveBlockVisibilities_27(base.GetCppThis());
		}

		// Token: 0x06014971 RID: 84337
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataDisplayAttributesLegacy_RemoveBlockVisibility_28(HandleRef pThis, uint flat_index);

		/// <summary>
		/// Removes the block visibility flag for the block with flat_index.
		/// </summary>
		// Token: 0x06014972 RID: 84338 RVA: 0x001D24DA File Offset: 0x001D06DA
		public void RemoveBlockVisibility(uint flat_index)
		{
			vtkCompositeDataDisplayAttributesLegacy.vtkCompositeDataDisplayAttributesLegacy_RemoveBlockVisibility_28(base.GetCppThis(), flat_index);
		}

		// Token: 0x06014973 RID: 84339
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeDataDisplayAttributesLegacy_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014974 RID: 84340 RVA: 0x001D24EC File Offset: 0x001D06EC
		public new static vtkCompositeDataDisplayAttributesLegacy SafeDownCast(vtkObjectBase o)
		{
			vtkCompositeDataDisplayAttributesLegacy vtkCompositeDataDisplayAttributesLegacy = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeDataDisplayAttributesLegacy.vtkCompositeDataDisplayAttributesLegacy_SafeDownCast_29((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCompositeDataDisplayAttributesLegacy = (vtkCompositeDataDisplayAttributesLegacy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCompositeDataDisplayAttributesLegacy.Register(null);
				}
			}
			return vtkCompositeDataDisplayAttributesLegacy;
		}

		// Token: 0x06014975 RID: 84341
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataDisplayAttributesLegacy_SetBlockColor_30(HandleRef pThis, uint flat_index, IntPtr color);

		/// <summary>
		/// Set/get the color for the block with \p flat_index.
		/// </summary>
		// Token: 0x06014976 RID: 84342 RVA: 0x001D256B File Offset: 0x001D076B
		public void SetBlockColor(uint flat_index, IntPtr color)
		{
			vtkCompositeDataDisplayAttributesLegacy.vtkCompositeDataDisplayAttributesLegacy_SetBlockColor_30(base.GetCppThis(), flat_index, color);
		}

		// Token: 0x06014977 RID: 84343
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataDisplayAttributesLegacy_SetBlockOpacity_31(HandleRef pThis, uint flat_index, double opacity);

		/// <summary>
		/// Set/get the opacity for the block with flat_index.
		/// </summary>
		// Token: 0x06014978 RID: 84344 RVA: 0x001D257C File Offset: 0x001D077C
		public void SetBlockOpacity(uint flat_index, double opacity)
		{
			vtkCompositeDataDisplayAttributesLegacy.vtkCompositeDataDisplayAttributesLegacy_SetBlockOpacity_31(base.GetCppThis(), flat_index, opacity);
		}

		// Token: 0x06014979 RID: 84345
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataDisplayAttributesLegacy_SetBlockPickability_32(HandleRef pThis, uint flat_index, byte visible);

		/// <summary>
		/// Set/get the visibility for the block with \p flat_index.
		/// </summary>
		// Token: 0x0601497A RID: 84346 RVA: 0x001D258D File Offset: 0x001D078D
		public void SetBlockPickability(uint flat_index, bool visible)
		{
			vtkCompositeDataDisplayAttributesLegacy.vtkCompositeDataDisplayAttributesLegacy_SetBlockPickability_32(base.GetCppThis(), flat_index, visible ? (byte)1 : (byte)0);
		}

		// Token: 0x0601497B RID: 84347
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataDisplayAttributesLegacy_SetBlockVisibility_33(HandleRef pThis, uint flat_index, byte visible);

		/// <summary>
		/// Set/get the visibility for the block with \p flat_index.
		/// </summary>
		// Token: 0x0601497C RID: 84348 RVA: 0x001D25A6 File Offset: 0x001D07A6
		public void SetBlockVisibility(uint flat_index, bool visible)
		{
			vtkCompositeDataDisplayAttributesLegacy.vtkCompositeDataDisplayAttributesLegacy_SetBlockVisibility_33(base.GetCppThis(), flat_index, visible ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040017D0 RID: 6096
		public new const string MRFullTypeName = "Kitware.VTK.vtkCompositeDataDisplayAttributesLegacy";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040017D1 RID: 6097
		public new static readonly string MRClassNameKey = "class vtkCompositeDataDisplayAttributesLegacy";
	}
}
