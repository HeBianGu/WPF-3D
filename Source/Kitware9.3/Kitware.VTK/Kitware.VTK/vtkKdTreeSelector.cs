using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkKdTreeSelector
	/// </summary>
	/// <remarks>
	///    Selects point ids using a kd-tree.
	///
	///
	/// If SetKdTree is used, the filter ignores the input and selects based on that
	/// kd-tree.  If SetKdTree is not used, the filter builds a kd-tree using the
	/// input point set and uses that tree for selection.  The output is a
	/// vtkSelection containing the ids found in the kd-tree using the specified
	/// bounds.
	/// </remarks>
	// Token: 0x0200041B RID: 1051
	public class vtkKdTreeSelector : vtkSelectionAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600C5FA RID: 50682 RVA: 0x001137DB File Offset: 0x001119DB
		static vtkKdTreeSelector()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkKdTreeSelector.MRClassNameKey, Type.GetType("Kitware.VTK.vtkKdTreeSelector"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600C5FB RID: 50683 RVA: 0x00113803 File Offset: 0x00111A03
		public vtkKdTreeSelector(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600C5FC RID: 50684
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkKdTreeSelector_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C5FD RID: 50685 RVA: 0x00113814 File Offset: 0x00111A14
		public new static vtkKdTreeSelector New()
		{
			vtkKdTreeSelector result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkKdTreeSelector.vtkKdTreeSelector_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkKdTreeSelector)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C5FE RID: 50686 RVA: 0x00113868 File Offset: 0x00111A68
		public vtkKdTreeSelector() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkKdTreeSelector.vtkKdTreeSelector_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600C5FF RID: 50687 RVA: 0x001138AC File Offset: 0x00111AAC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600C600 RID: 50688
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkKdTreeSelector_GetKdTree_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The kd-tree to use to find selected ids.
		/// The kd-tree must be initialized with the desired set of points.
		/// When this is set, the optional input is ignored.
		/// </summary>
		// Token: 0x0600C601 RID: 50689 RVA: 0x001138B8 File Offset: 0x00111AB8
		public virtual vtkKdTree GetKdTree()
		{
			vtkKdTree vtkKdTree = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkKdTreeSelector.vtkKdTreeSelector_GetKdTree_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkKdTree = (vtkKdTree)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkKdTree.Register(null);
				}
			}
			return vtkKdTree;
		}

		// Token: 0x0600C602 RID: 50690
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkKdTreeSelector_GetMTime_02(HandleRef pThis);

		/// <summary>
		/// The threshold for the single selection.
		/// A single point is added to the selection if it is within
		/// this threshold from the bounds center.
		/// Default is 1.
		/// </summary>
		// Token: 0x0600C603 RID: 50691 RVA: 0x00113928 File Offset: 0x00111B28
		public override ulong GetMTime()
		{
			return vtkKdTreeSelector.vtkKdTreeSelector_GetMTime_02(base.GetCppThis());
		}

		// Token: 0x0600C604 RID: 50692
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkKdTreeSelector_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C605 RID: 50693 RVA: 0x00113948 File Offset: 0x00111B48
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkKdTreeSelector.vtkKdTreeSelector_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0600C606 RID: 50694
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkKdTreeSelector_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C607 RID: 50695 RVA: 0x00113968 File Offset: 0x00111B68
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkKdTreeSelector.vtkKdTreeSelector_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0600C608 RID: 50696
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkKdTreeSelector_GetSelectionAttribute_05(HandleRef pThis);

		/// <summary>
		/// The field attribute to use when generating the selection.
		/// If set, creates a PEDIGREEIDS or GLOBALIDS selection.
		/// If not set (or is set to -1), creates a INDICES selection.
		/// By default this is not set.
		/// NOTE: This should be set a constant in vtkDataSetAttributes,
		/// not vtkSelection.
		/// </summary>
		// Token: 0x0600C609 RID: 50697 RVA: 0x00113984 File Offset: 0x00111B84
		public virtual int GetSelectionAttribute()
		{
			return vtkKdTreeSelector.vtkKdTreeSelector_GetSelectionAttribute_05(base.GetCppThis());
		}

		// Token: 0x0600C60A RID: 50698
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkKdTreeSelector_GetSelectionBounds_06(HandleRef pThis);

		/// <summary>
		/// The bounds of the form (xmin,xmax,ymin,ymax,zmin,zmax).
		/// To perform a search in 2D, use the bounds
		/// (xmin,xmax,ymin,ymax,VTK_DOUBLE_MIN,VTK_DOUBLE_MAX).
		/// </summary>
		// Token: 0x0600C60B RID: 50699 RVA: 0x001139A4 File Offset: 0x00111BA4
		public virtual double[] GetSelectionBounds()
		{
			IntPtr intPtr = vtkKdTreeSelector.vtkKdTreeSelector_GetSelectionBounds_06(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600C60C RID: 50700
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdTreeSelector_GetSelectionBounds_07(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6);

		/// <summary>
		/// The bounds of the form (xmin,xmax,ymin,ymax,zmin,zmax).
		/// To perform a search in 2D, use the bounds
		/// (xmin,xmax,ymin,ymax,VTK_DOUBLE_MIN,VTK_DOUBLE_MAX).
		/// </summary>
		// Token: 0x0600C60D RID: 50701 RVA: 0x001139EC File Offset: 0x00111BEC
		public virtual void GetSelectionBounds(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6)
		{
			vtkKdTreeSelector.vtkKdTreeSelector_GetSelectionBounds_07(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		// Token: 0x0600C60E RID: 50702
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdTreeSelector_GetSelectionBounds_08(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// The bounds of the form (xmin,xmax,ymin,ymax,zmin,zmax).
		/// To perform a search in 2D, use the bounds
		/// (xmin,xmax,ymin,ymax,VTK_DOUBLE_MIN,VTK_DOUBLE_MAX).
		/// </summary>
		// Token: 0x0600C60F RID: 50703 RVA: 0x00113A04 File Offset: 0x00111C04
		public virtual void GetSelectionBounds(IntPtr _arg)
		{
			vtkKdTreeSelector.vtkKdTreeSelector_GetSelectionBounds_08(base.GetCppThis(), _arg);
		}

		// Token: 0x0600C610 RID: 50704
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkKdTreeSelector_GetSelectionFieldName_09(HandleRef pThis);

		/// <summary>
		/// The field name to use when generating the selection.
		/// If set, creates a VALUES selection.
		/// If not set (or is set to nullptr), creates a INDICES selection.
		/// By default this is not set.
		/// </summary>
		// Token: 0x0600C611 RID: 50705 RVA: 0x00113A14 File Offset: 0x00111C14
		public virtual string GetSelectionFieldName()
		{
			string s = Marshal.PtrToStringAnsi(vtkKdTreeSelector.vtkKdTreeSelector_GetSelectionFieldName_09(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600C612 RID: 50706
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkKdTreeSelector_GetSingleSelection_10(HandleRef pThis);

		/// <summary>
		/// Whether to only allow up to one value in the result.
		/// The item selected is closest to the center of the bounds,
		/// if there are any points within the selection threshold.
		/// Default is off.
		/// </summary>
		// Token: 0x0600C613 RID: 50707 RVA: 0x00113A50 File Offset: 0x00111C50
		public virtual bool GetSingleSelection()
		{
			return vtkKdTreeSelector.vtkKdTreeSelector_GetSingleSelection_10(base.GetCppThis()) != 0;
		}

		// Token: 0x0600C614 RID: 50708
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkKdTreeSelector_GetSingleSelectionThreshold_11(HandleRef pThis);

		/// <summary>
		/// The threshold for the single selection.
		/// A single point is added to the selection if it is within
		/// this threshold from the bounds center.
		/// Default is 1.
		/// </summary>
		// Token: 0x0600C615 RID: 50709 RVA: 0x00113A78 File Offset: 0x00111C78
		public virtual double GetSingleSelectionThreshold()
		{
			return vtkKdTreeSelector.vtkKdTreeSelector_GetSingleSelectionThreshold_11(base.GetCppThis());
		}

		// Token: 0x0600C616 RID: 50710
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkKdTreeSelector_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C617 RID: 50711 RVA: 0x00113A98 File Offset: 0x00111C98
		public override int IsA(string type)
		{
			return vtkKdTreeSelector.vtkKdTreeSelector_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x0600C618 RID: 50712
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkKdTreeSelector_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C619 RID: 50713 RVA: 0x00113AB8 File Offset: 0x00111CB8
		public new static int IsTypeOf(string type)
		{
			return vtkKdTreeSelector.vtkKdTreeSelector_IsTypeOf_13(type);
		}

		// Token: 0x0600C61A RID: 50714
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkKdTreeSelector_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C61B RID: 50715 RVA: 0x00113AD4 File Offset: 0x00111CD4
		public new vtkKdTreeSelector NewInstance()
		{
			vtkKdTreeSelector result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkKdTreeSelector.vtkKdTreeSelector_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkKdTreeSelector)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600C61C RID: 50716
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkKdTreeSelector_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C61D RID: 50717 RVA: 0x00113B30 File Offset: 0x00111D30
		public new static vtkKdTreeSelector SafeDownCast(vtkObjectBase o)
		{
			vtkKdTreeSelector vtkKdTreeSelector = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkKdTreeSelector.vtkKdTreeSelector_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkKdTreeSelector = (vtkKdTreeSelector)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkKdTreeSelector.Register(null);
				}
			}
			return vtkKdTreeSelector;
		}

		// Token: 0x0600C61E RID: 50718
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdTreeSelector_SetKdTree_17(HandleRef pThis, HandleRef tree);

		/// <summary>
		/// The kd-tree to use to find selected ids.
		/// The kd-tree must be initialized with the desired set of points.
		/// When this is set, the optional input is ignored.
		/// </summary>
		// Token: 0x0600C61F RID: 50719 RVA: 0x00113BB0 File Offset: 0x00111DB0
		public void SetKdTree(vtkKdTree tree)
		{
			vtkKdTreeSelector.vtkKdTreeSelector_SetKdTree_17(base.GetCppThis(), (tree == null) ? default(HandleRef) : tree.GetCppThis());
		}

		// Token: 0x0600C620 RID: 50720
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdTreeSelector_SetSelectionAttribute_18(HandleRef pThis, int _arg);

		/// <summary>
		/// The field attribute to use when generating the selection.
		/// If set, creates a PEDIGREEIDS or GLOBALIDS selection.
		/// If not set (or is set to -1), creates a INDICES selection.
		/// By default this is not set.
		/// NOTE: This should be set a constant in vtkDataSetAttributes,
		/// not vtkSelection.
		/// </summary>
		// Token: 0x0600C621 RID: 50721 RVA: 0x00113BDF File Offset: 0x00111DDF
		public virtual void SetSelectionAttribute(int _arg)
		{
			vtkKdTreeSelector.vtkKdTreeSelector_SetSelectionAttribute_18(base.GetCppThis(), _arg);
		}

		// Token: 0x0600C622 RID: 50722
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdTreeSelector_SetSelectionBounds_19(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

		/// <summary>
		/// The bounds of the form (xmin,xmax,ymin,ymax,zmin,zmax).
		/// To perform a search in 2D, use the bounds
		/// (xmin,xmax,ymin,ymax,VTK_DOUBLE_MIN,VTK_DOUBLE_MAX).
		/// </summary>
		// Token: 0x0600C623 RID: 50723 RVA: 0x00113BEF File Offset: 0x00111DEF
		public virtual void SetSelectionBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
		{
			vtkKdTreeSelector.vtkKdTreeSelector_SetSelectionBounds_19(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		// Token: 0x0600C624 RID: 50724
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdTreeSelector_SetSelectionBounds_20(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// The bounds of the form (xmin,xmax,ymin,ymax,zmin,zmax).
		/// To perform a search in 2D, use the bounds
		/// (xmin,xmax,ymin,ymax,VTK_DOUBLE_MIN,VTK_DOUBLE_MAX).
		/// </summary>
		// Token: 0x0600C625 RID: 50725 RVA: 0x00113C07 File Offset: 0x00111E07
		public virtual void SetSelectionBounds(IntPtr _arg)
		{
			vtkKdTreeSelector.vtkKdTreeSelector_SetSelectionBounds_20(base.GetCppThis(), _arg);
		}

		// Token: 0x0600C626 RID: 50726
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdTreeSelector_SetSelectionFieldName_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// The field name to use when generating the selection.
		/// If set, creates a VALUES selection.
		/// If not set (or is set to nullptr), creates a INDICES selection.
		/// By default this is not set.
		/// </summary>
		// Token: 0x0600C627 RID: 50727 RVA: 0x00113C17 File Offset: 0x00111E17
		public virtual void SetSelectionFieldName(string _arg)
		{
			vtkKdTreeSelector.vtkKdTreeSelector_SetSelectionFieldName_21(base.GetCppThis(), _arg);
		}

		// Token: 0x0600C628 RID: 50728
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdTreeSelector_SetSingleSelection_22(HandleRef pThis, byte _arg);

		/// <summary>
		/// Whether to only allow up to one value in the result.
		/// The item selected is closest to the center of the bounds,
		/// if there are any points within the selection threshold.
		/// Default is off.
		/// </summary>
		// Token: 0x0600C629 RID: 50729 RVA: 0x00113C27 File Offset: 0x00111E27
		public virtual void SetSingleSelection(bool _arg)
		{
			vtkKdTreeSelector.vtkKdTreeSelector_SetSingleSelection_22(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600C62A RID: 50730
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdTreeSelector_SetSingleSelectionThreshold_23(HandleRef pThis, double _arg);

		/// <summary>
		/// The threshold for the single selection.
		/// A single point is added to the selection if it is within
		/// this threshold from the bounds center.
		/// Default is 1.
		/// </summary>
		// Token: 0x0600C62B RID: 50731 RVA: 0x00113C3F File Offset: 0x00111E3F
		public virtual void SetSingleSelectionThreshold(double _arg)
		{
			vtkKdTreeSelector.vtkKdTreeSelector_SetSingleSelectionThreshold_23(base.GetCppThis(), _arg);
		}

		// Token: 0x0600C62C RID: 50732
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdTreeSelector_SingleSelectionOff_24(HandleRef pThis);

		/// <summary>
		/// Whether to only allow up to one value in the result.
		/// The item selected is closest to the center of the bounds,
		/// if there are any points within the selection threshold.
		/// Default is off.
		/// </summary>
		// Token: 0x0600C62D RID: 50733 RVA: 0x00113C4F File Offset: 0x00111E4F
		public virtual void SingleSelectionOff()
		{
			vtkKdTreeSelector.vtkKdTreeSelector_SingleSelectionOff_24(base.GetCppThis());
		}

		// Token: 0x0600C62E RID: 50734
		[DllImport("Kitware.VTK.FiltersSelection.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdTreeSelector_SingleSelectionOn_25(HandleRef pThis);

		/// <summary>
		/// Whether to only allow up to one value in the result.
		/// The item selected is closest to the center of the bounds,
		/// if there are any points within the selection threshold.
		/// Default is off.
		/// </summary>
		// Token: 0x0600C62F RID: 50735 RVA: 0x00113C5E File Offset: 0x00111E5E
		public virtual void SingleSelectionOn()
		{
			vtkKdTreeSelector.vtkKdTreeSelector_SingleSelectionOn_25(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000EC7 RID: 3783
		public new const string MRFullTypeName = "Kitware.VTK.vtkKdTreeSelector";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000EC8 RID: 3784
		public new static readonly string MRClassNameKey = "class vtkKdTreeSelector";
	}
}
