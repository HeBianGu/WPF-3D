using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkCompositePolyDataMapperDelegator
	/// </summary>
	/// <remarks>
	///  Delegates rendering of multiple polydata that share similar signatures.
	///
	/// Concrete graphics implementations are expected to manage and trampoline
	/// render functions to the delegate.
	///
	/// </remarks>
	/// <seealso>
	///  vtkOpenGLCompositePolyDataMapperDelegator vtkCompositePolyDataMapper
	/// </seealso>
	// Token: 0x02000106 RID: 262
	public abstract class vtkCompositePolyDataMapperDelegator : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060035FA RID: 13818 RVA: 0x0004EBBB File Offset: 0x0004CDBB
		static vtkCompositePolyDataMapperDelegator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCompositePolyDataMapperDelegator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCompositePolyDataMapperDelegator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060035FB RID: 13819 RVA: 0x0004EBE3 File Offset: 0x0004CDE3
		public vtkCompositePolyDataMapperDelegator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060035FC RID: 13820
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositePolyDataMapperDelegator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060035FD RID: 13821 RVA: 0x0004EBF4 File Offset: 0x0004CDF4
		public new static vtkCompositePolyDataMapperDelegator New()
		{
			vtkCompositePolyDataMapperDelegator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositePolyDataMapperDelegator.vtkCompositePolyDataMapperDelegator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompositePolyDataMapperDelegator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060035FE RID: 13822 RVA: 0x0004EC48 File Offset: 0x0004CE48
		public vtkCompositePolyDataMapperDelegator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCompositePolyDataMapperDelegator.vtkCompositePolyDataMapperDelegator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060035FF RID: 13823 RVA: 0x0004EC8C File Offset: 0x0004CE8C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06003600 RID: 13824
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapperDelegator_Clear_01(HandleRef pThis);

		/// <summary>
		/// Clear all batch elements.
		/// </summary>
		// Token: 0x06003601 RID: 13825 RVA: 0x0004EC97 File Offset: 0x0004CE97
		public virtual void Clear()
		{
			vtkCompositePolyDataMapperDelegator.vtkCompositePolyDataMapperDelegator_Clear_01(base.GetCppThis());
		}

		// Token: 0x06003602 RID: 13826
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapperDelegator_ClearUnmarkedBatchElements_02(HandleRef pThis);

		/// <summary>
		/// Keep track of what data is being used as the structure
		/// can change
		/// </summary>
		// Token: 0x06003603 RID: 13827 RVA: 0x0004ECA6 File Offset: 0x0004CEA6
		public virtual void ClearUnmarkedBatchElements()
		{
			vtkCompositePolyDataMapperDelegator.vtkCompositePolyDataMapperDelegator_ClearUnmarkedBatchElements_02(base.GetCppThis());
		}

		// Token: 0x06003604 RID: 13828
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCompositePolyDataMapperDelegator_GetMarked_03(HandleRef pThis);

		/// <summary>
		/// Keep track of what data is being used as the structure
		/// can change
		/// </summary>
		// Token: 0x06003605 RID: 13829 RVA: 0x0004ECB8 File Offset: 0x0004CEB8
		public bool GetMarked()
		{
			return vtkCompositePolyDataMapperDelegator.vtkCompositePolyDataMapperDelegator_GetMarked_03(base.GetCppThis()) != 0;
		}

		// Token: 0x06003606 RID: 13830
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCompositePolyDataMapperDelegator_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003607 RID: 13831 RVA: 0x0004ECE0 File Offset: 0x0004CEE0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCompositePolyDataMapperDelegator.vtkCompositePolyDataMapperDelegator_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06003608 RID: 13832
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCompositePolyDataMapperDelegator_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003609 RID: 13833 RVA: 0x0004ED00 File Offset: 0x0004CF00
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCompositePolyDataMapperDelegator.vtkCompositePolyDataMapperDelegator_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0600360A RID: 13834
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompositePolyDataMapperDelegator_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600360B RID: 13835 RVA: 0x0004ED1C File Offset: 0x0004CF1C
		public override int IsA(string type)
		{
			return vtkCompositePolyDataMapperDelegator.vtkCompositePolyDataMapperDelegator_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0600360C RID: 13836
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompositePolyDataMapperDelegator_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600360D RID: 13837 RVA: 0x0004ED3C File Offset: 0x0004CF3C
		public new static int IsTypeOf(string type)
		{
			return vtkCompositePolyDataMapperDelegator.vtkCompositePolyDataMapperDelegator_IsTypeOf_07(type);
		}

		// Token: 0x0600360E RID: 13838
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapperDelegator_Mark_08(HandleRef pThis);

		/// <summary>
		/// Keep track of what data is being used as the structure
		/// can change
		/// </summary>
		// Token: 0x0600360F RID: 13839 RVA: 0x0004ED56 File Offset: 0x0004CF56
		public void Mark()
		{
			vtkCompositePolyDataMapperDelegator.vtkCompositePolyDataMapperDelegator_Mark_08(base.GetCppThis());
		}

		// Token: 0x06003610 RID: 13840
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositePolyDataMapperDelegator_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003611 RID: 13841 RVA: 0x0004ED68 File Offset: 0x0004CF68
		public new vtkCompositePolyDataMapperDelegator NewInstance()
		{
			vtkCompositePolyDataMapperDelegator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositePolyDataMapperDelegator.vtkCompositePolyDataMapperDelegator_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompositePolyDataMapperDelegator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06003612 RID: 13842
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositePolyDataMapperDelegator_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003613 RID: 13843 RVA: 0x0004EDC4 File Offset: 0x0004CFC4
		public new static vtkCompositePolyDataMapperDelegator SafeDownCast(vtkObjectBase o)
		{
			vtkCompositePolyDataMapperDelegator vtkCompositePolyDataMapperDelegator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositePolyDataMapperDelegator.vtkCompositePolyDataMapperDelegator_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCompositePolyDataMapperDelegator = (vtkCompositePolyDataMapperDelegator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCompositePolyDataMapperDelegator.Register(null);
				}
			}
			return vtkCompositePolyDataMapperDelegator;
		}

		// Token: 0x06003614 RID: 13844
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapperDelegator_SetParent_12(HandleRef pThis, HandleRef mapper);

		/// <summary>
		/// Assign a parent mapper. The parent enables delegates to access
		/// higher level attributes.
		///
		/// Delegates can access attributes like ColorMissingArraysWithNanColor
		/// and selection accessed. Also, they can invoke events on the parent mapper.
		/// Ex: UpdateShaderEvent
		/// </summary>
		// Token: 0x06003615 RID: 13845 RVA: 0x0004EE44 File Offset: 0x0004D044
		public virtual void SetParent(vtkCompositePolyDataMapper mapper)
		{
			vtkCompositePolyDataMapperDelegator.vtkCompositePolyDataMapperDelegator_SetParent_12(base.GetCppThis(), (mapper == null) ? default(HandleRef) : mapper.GetCppThis());
		}

		// Token: 0x06003616 RID: 13846
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapperDelegator_ShallowCopy_13(HandleRef pThis, HandleRef polydataMapper);

		/// <summary>
		/// Shallow copies scalar array related properties into the delegate.
		/// </summary>
		// Token: 0x06003617 RID: 13847 RVA: 0x0004EE74 File Offset: 0x0004D074
		public virtual void ShallowCopy(vtkCompositePolyDataMapper polydataMapper)
		{
			vtkCompositePolyDataMapperDelegator.vtkCompositePolyDataMapperDelegator_ShallowCopy_13(base.GetCppThis(), (polydataMapper == null) ? default(HandleRef) : polydataMapper.GetCppThis());
		}

		// Token: 0x06003618 RID: 13848
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapperDelegator_Unmark_14(HandleRef pThis);

		/// <summary>
		/// Keep track of what data is being used as the structure
		/// can change
		/// </summary>
		// Token: 0x06003619 RID: 13849 RVA: 0x0004EEA3 File Offset: 0x0004D0A3
		public void Unmark()
		{
			vtkCompositePolyDataMapperDelegator.vtkCompositePolyDataMapperDelegator_Unmark_14(base.GetCppThis());
		}

		// Token: 0x0600361A RID: 13850
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositePolyDataMapperDelegator_UnmarkBatchElements_15(HandleRef pThis);

		/// <summary>
		/// Keep track of what data is being used as the structure
		/// can change
		/// </summary>
		// Token: 0x0600361B RID: 13851 RVA: 0x0004EEB2 File Offset: 0x0004D0B2
		public virtual void UnmarkBatchElements()
		{
			vtkCompositePolyDataMapperDelegator.vtkCompositePolyDataMapperDelegator_UnmarkBatchElements_15(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000644 RID: 1604
		public new const string MRFullTypeName = "Kitware.VTK.vtkCompositePolyDataMapperDelegator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000645 RID: 1605
		public new static readonly string MRClassNameKey = "class vtkCompositePolyDataMapperDelegator";
	}
}
