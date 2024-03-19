using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPerturbCoincidentVertices
	/// </summary>
	/// <remarks>
	///    Perturbs vertices that are coincident.
	///
	///
	/// This filter perturbs vertices in a graph that have coincident coordinates.
	/// In particular this happens all the time with graphs that are georeferenced,
	/// so we need a nice scheme to perturb the vertices so that when the user
	/// zooms in the vertices can be distiquished.
	/// </remarks>
	// Token: 0x02000296 RID: 662
	public class vtkPerturbCoincidentVertices : vtkGraphAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060077C0 RID: 30656 RVA: 0x000ACB93 File Offset: 0x000AAD93
		static vtkPerturbCoincidentVertices()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPerturbCoincidentVertices.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPerturbCoincidentVertices"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060077C1 RID: 30657 RVA: 0x000ACBBB File Offset: 0x000AADBB
		public vtkPerturbCoincidentVertices(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060077C2 RID: 30658
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPerturbCoincidentVertices_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060077C3 RID: 30659 RVA: 0x000ACBCC File Offset: 0x000AADCC
		public new static vtkPerturbCoincidentVertices New()
		{
			vtkPerturbCoincidentVertices result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPerturbCoincidentVertices.vtkPerturbCoincidentVertices_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPerturbCoincidentVertices)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060077C4 RID: 30660 RVA: 0x000ACC20 File Offset: 0x000AAE20
		public vtkPerturbCoincidentVertices() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPerturbCoincidentVertices.vtkPerturbCoincidentVertices_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060077C5 RID: 30661 RVA: 0x000ACC64 File Offset: 0x000AAE64
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060077C6 RID: 30662
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPerturbCoincidentVertices_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060077C7 RID: 30663 RVA: 0x000ACC70 File Offset: 0x000AAE70
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPerturbCoincidentVertices.vtkPerturbCoincidentVertices_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x060077C8 RID: 30664
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPerturbCoincidentVertices_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060077C9 RID: 30665 RVA: 0x000ACC90 File Offset: 0x000AAE90
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPerturbCoincidentVertices.vtkPerturbCoincidentVertices_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x060077CA RID: 30666
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPerturbCoincidentVertices_GetPerturbFactor_03(HandleRef pThis);

		/// <summary>
		/// Specify the perturbation factor (defaults to 1.0)
		/// </summary>
		// Token: 0x060077CB RID: 30667 RVA: 0x000ACCAC File Offset: 0x000AAEAC
		public virtual double GetPerturbFactor()
		{
			return vtkPerturbCoincidentVertices.vtkPerturbCoincidentVertices_GetPerturbFactor_03(base.GetCppThis());
		}

		// Token: 0x060077CC RID: 30668
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPerturbCoincidentVertices_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060077CD RID: 30669 RVA: 0x000ACCCC File Offset: 0x000AAECC
		public override int IsA(string type)
		{
			return vtkPerturbCoincidentVertices.vtkPerturbCoincidentVertices_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x060077CE RID: 30670
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPerturbCoincidentVertices_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060077CF RID: 30671 RVA: 0x000ACCEC File Offset: 0x000AAEEC
		public new static int IsTypeOf(string type)
		{
			return vtkPerturbCoincidentVertices.vtkPerturbCoincidentVertices_IsTypeOf_05(type);
		}

		// Token: 0x060077D0 RID: 30672
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPerturbCoincidentVertices_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060077D1 RID: 30673 RVA: 0x000ACD08 File Offset: 0x000AAF08
		public new vtkPerturbCoincidentVertices NewInstance()
		{
			vtkPerturbCoincidentVertices result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPerturbCoincidentVertices.vtkPerturbCoincidentVertices_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPerturbCoincidentVertices)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060077D2 RID: 30674
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPerturbCoincidentVertices_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060077D3 RID: 30675 RVA: 0x000ACD64 File Offset: 0x000AAF64
		public new static vtkPerturbCoincidentVertices SafeDownCast(vtkObjectBase o)
		{
			vtkPerturbCoincidentVertices vtkPerturbCoincidentVertices = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPerturbCoincidentVertices.vtkPerturbCoincidentVertices_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPerturbCoincidentVertices = (vtkPerturbCoincidentVertices)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPerturbCoincidentVertices.Register(null);
				}
			}
			return vtkPerturbCoincidentVertices;
		}

		// Token: 0x060077D4 RID: 30676
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPerturbCoincidentVertices_SetPerturbFactor_09(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the perturbation factor (defaults to 1.0)
		/// </summary>
		// Token: 0x060077D5 RID: 30677 RVA: 0x000ACDE3 File Offset: 0x000AAFE3
		public virtual void SetPerturbFactor(double _arg)
		{
			vtkPerturbCoincidentVertices.vtkPerturbCoincidentVertices_SetPerturbFactor_09(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A3A RID: 2618
		public new const string MRFullTypeName = "Kitware.VTK.vtkPerturbCoincidentVertices";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A3B RID: 2619
		public new static readonly string MRClassNameKey = "class vtkPerturbCoincidentVertices";
	}
}
