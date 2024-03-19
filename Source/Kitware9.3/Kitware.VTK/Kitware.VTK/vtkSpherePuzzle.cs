using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSpherePuzzle
	/// </summary>
	/// <remarks>
	///    create a polygonal sphere centered at the origin
	///
	/// vtkSpherePuzzle creates
	/// </remarks>
	// Token: 0x02000570 RID: 1392
	public class vtkSpherePuzzle : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600F6FE RID: 63230 RVA: 0x001574F0 File Offset: 0x001556F0
		static vtkSpherePuzzle()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSpherePuzzle.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSpherePuzzle"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600F6FF RID: 63231 RVA: 0x00157518 File Offset: 0x00155718
		public vtkSpherePuzzle(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600F700 RID: 63232
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSpherePuzzle_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F701 RID: 63233 RVA: 0x00157528 File Offset: 0x00155728
		public new static vtkSpherePuzzle New()
		{
			vtkSpherePuzzle result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSpherePuzzle.vtkSpherePuzzle_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSpherePuzzle)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F702 RID: 63234 RVA: 0x0015757C File Offset: 0x0015577C
		public vtkSpherePuzzle() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSpherePuzzle.vtkSpherePuzzle_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600F703 RID: 63235 RVA: 0x001575C0 File Offset: 0x001557C0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600F704 RID: 63236
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSpherePuzzle_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F705 RID: 63237 RVA: 0x001575CC File Offset: 0x001557CC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSpherePuzzle.vtkSpherePuzzle_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600F706 RID: 63238
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSpherePuzzle_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F707 RID: 63239 RVA: 0x001575EC File Offset: 0x001557EC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSpherePuzzle.vtkSpherePuzzle_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600F708 RID: 63240
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSpherePuzzle_GetState_03(HandleRef pThis);

		/// <summary>
		/// For drawing state as arrows.
		/// </summary>
		// Token: 0x0600F709 RID: 63241 RVA: 0x00157608 File Offset: 0x00155808
		public IntPtr GetState()
		{
			return vtkSpherePuzzle.vtkSpherePuzzle_GetState_03(base.GetCppThis());
		}

		// Token: 0x0600F70A RID: 63242
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSpherePuzzle_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F70B RID: 63243 RVA: 0x00157628 File Offset: 0x00155828
		public override int IsA(string type)
		{
			return vtkSpherePuzzle.vtkSpherePuzzle_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600F70C RID: 63244
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSpherePuzzle_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F70D RID: 63245 RVA: 0x00157648 File Offset: 0x00155848
		public new static int IsTypeOf(string type)
		{
			return vtkSpherePuzzle.vtkSpherePuzzle_IsTypeOf_05(type);
		}

		// Token: 0x0600F70E RID: 63246
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpherePuzzle_MoveHorizontal_06(HandleRef pThis, int section, int percentage, int rightFlag);

		/// <summary>
		/// Move the top/bottom half one segment either direction.
		/// </summary>
		// Token: 0x0600F70F RID: 63247 RVA: 0x00157662 File Offset: 0x00155862
		public void MoveHorizontal(int section, int percentage, int rightFlag)
		{
			vtkSpherePuzzle.vtkSpherePuzzle_MoveHorizontal_06(base.GetCppThis(), section, percentage, rightFlag);
		}

		// Token: 0x0600F710 RID: 63248
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpherePuzzle_MovePoint_07(HandleRef pThis, int percentage);

		/// <summary>
		/// Move actually implements the pending move. When percentage
		/// is 100, the pending move becomes inactive, and SetPoint
		/// will have to be called again to setup another move.
		/// </summary>
		// Token: 0x0600F711 RID: 63249 RVA: 0x00157674 File Offset: 0x00155874
		public void MovePoint(int percentage)
		{
			vtkSpherePuzzle.vtkSpherePuzzle_MovePoint_07(base.GetCppThis(), percentage);
		}

		// Token: 0x0600F712 RID: 63250
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpherePuzzle_MoveVertical_08(HandleRef pThis, int section, int percentage, int rightFlag);

		/// <summary>
		/// Rotate vertical half of sphere along one of the longitude lines.
		/// </summary>
		// Token: 0x0600F713 RID: 63251 RVA: 0x00157684 File Offset: 0x00155884
		public void MoveVertical(int section, int percentage, int rightFlag)
		{
			vtkSpherePuzzle.vtkSpherePuzzle_MoveVertical_08(base.GetCppThis(), section, percentage, rightFlag);
		}

		// Token: 0x0600F714 RID: 63252
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSpherePuzzle_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F715 RID: 63253 RVA: 0x00157698 File Offset: 0x00155898
		public new vtkSpherePuzzle NewInstance()
		{
			vtkSpherePuzzle result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSpherePuzzle.vtkSpherePuzzle_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSpherePuzzle)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600F716 RID: 63254
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpherePuzzle_Reset_11(HandleRef pThis);

		/// <summary>
		/// Reset the state of this puzzle back to its original state.
		/// </summary>
		// Token: 0x0600F717 RID: 63255 RVA: 0x001576F2 File Offset: 0x001558F2
		public void Reset()
		{
			vtkSpherePuzzle.vtkSpherePuzzle_Reset_11(base.GetCppThis());
		}

		// Token: 0x0600F718 RID: 63256
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSpherePuzzle_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F719 RID: 63257 RVA: 0x00157704 File Offset: 0x00155904
		public new static vtkSpherePuzzle SafeDownCast(vtkObjectBase o)
		{
			vtkSpherePuzzle vtkSpherePuzzle = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSpherePuzzle.vtkSpherePuzzle_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSpherePuzzle = (vtkSpherePuzzle)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSpherePuzzle.Register(null);
				}
			}
			return vtkSpherePuzzle;
		}

		// Token: 0x0600F71A RID: 63258
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSpherePuzzle_SetPoint_13(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// SetPoint will be called as the mouse moves over the screen.
		/// The output will change to indicate the pending move.
		/// SetPoint returns zero if move is not activated by point.
		/// Otherwise it encodes the move into a unique integer so that
		/// the caller can determine if the move state has changed.
		/// This will answer the question, "Should I render."
		/// </summary>
		// Token: 0x0600F71B RID: 63259 RVA: 0x00157784 File Offset: 0x00155984
		public int SetPoint(double x, double y, double z)
		{
			return vtkSpherePuzzle.vtkSpherePuzzle_SetPoint_13(base.GetCppThis(), x, y, z);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040011F1 RID: 4593
		public new const string MRFullTypeName = "Kitware.VTK.vtkSpherePuzzle";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040011F2 RID: 4594
		public new static readonly string MRClassNameKey = "class vtkSpherePuzzle";
	}
}
