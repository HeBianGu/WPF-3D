using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkParallelVectors
	/// </summary>
	/// <remarks>
	///    Compute polylines corresponding to locations where two vector fields
	///          are parallel
	///
	/// vtkParallelVectors accepts a 3D dataset with two nodal 3-vector fields and
	/// generates polylines along the paths where the vector fields are parallel.
	/// This filter is an implementation of the concepts outlined in the following
	/// article:
	///
	/// R. Peikert and M. Roth, "The "Parallel Vectors" operator-a vector field
	/// visualization primitive," Proceedings Visualization '99 (Cat. No.99CB37067),
	/// San Francisco, CA, USA, 1999, pp. 263-532.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkVortexCore
	/// </seealso>
	// Token: 0x020004B7 RID: 1207
	public class vtkParallelVectors : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600DDBE RID: 56766 RVA: 0x00133DBF File Offset: 0x00131FBF
		static vtkParallelVectors()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkParallelVectors.MRClassNameKey, Type.GetType("Kitware.VTK.vtkParallelVectors"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600DDBF RID: 56767 RVA: 0x00133DE7 File Offset: 0x00131FE7
		public vtkParallelVectors(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600DDC0 RID: 56768
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParallelVectors_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DDC1 RID: 56769 RVA: 0x00133DF8 File Offset: 0x00131FF8
		public new static vtkParallelVectors New()
		{
			vtkParallelVectors result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParallelVectors.vtkParallelVectors_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParallelVectors)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DDC2 RID: 56770 RVA: 0x00133E4C File Offset: 0x0013204C
		public vtkParallelVectors() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkParallelVectors.vtkParallelVectors_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600DDC3 RID: 56771 RVA: 0x00133E90 File Offset: 0x00132090
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600DDC4 RID: 56772
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParallelVectors_GetFirstVectorFieldName_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the name of first vector field.
		/// </summary>
		// Token: 0x0600DDC5 RID: 56773 RVA: 0x00133E9C File Offset: 0x0013209C
		public virtual string GetFirstVectorFieldName()
		{
			string s = Marshal.PtrToStringAnsi(vtkParallelVectors.vtkParallelVectors_GetFirstVectorFieldName_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600DDC6 RID: 56774
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParallelVectors_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DDC7 RID: 56775 RVA: 0x00133ED8 File Offset: 0x001320D8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkParallelVectors.vtkParallelVectors_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600DDC8 RID: 56776
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParallelVectors_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DDC9 RID: 56777 RVA: 0x00133EF8 File Offset: 0x001320F8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkParallelVectors.vtkParallelVectors_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600DDCA RID: 56778
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParallelVectors_GetSecondVectorFieldName_04(HandleRef pThis);

		/// <summary>
		/// Set/Get the name of second vector field.
		/// </summary>
		// Token: 0x0600DDCB RID: 56779 RVA: 0x00133F14 File Offset: 0x00132114
		public virtual string GetSecondVectorFieldName()
		{
			string s = Marshal.PtrToStringAnsi(vtkParallelVectors.vtkParallelVectors_GetSecondVectorFieldName_04(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600DDCC RID: 56780
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParallelVectors_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DDCD RID: 56781 RVA: 0x00133F50 File Offset: 0x00132150
		public override int IsA(string type)
		{
			return vtkParallelVectors.vtkParallelVectors_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0600DDCE RID: 56782
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParallelVectors_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DDCF RID: 56783 RVA: 0x00133F70 File Offset: 0x00132170
		public new static int IsTypeOf(string type)
		{
			return vtkParallelVectors.vtkParallelVectors_IsTypeOf_06(type);
		}

		// Token: 0x0600DDD0 RID: 56784
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParallelVectors_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DDD1 RID: 56785 RVA: 0x00133F8C File Offset: 0x0013218C
		public new vtkParallelVectors NewInstance()
		{
			vtkParallelVectors result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParallelVectors.vtkParallelVectors_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParallelVectors)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600DDD2 RID: 56786
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParallelVectors_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DDD3 RID: 56787 RVA: 0x00133FE8 File Offset: 0x001321E8
		public new static vtkParallelVectors SafeDownCast(vtkObjectBase o)
		{
			vtkParallelVectors vtkParallelVectors = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParallelVectors.vtkParallelVectors_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkParallelVectors = (vtkParallelVectors)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkParallelVectors.Register(null);
				}
			}
			return vtkParallelVectors;
		}

		// Token: 0x0600DDD4 RID: 56788
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelVectors_SetFirstVectorFieldName_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the name of first vector field.
		/// </summary>
		// Token: 0x0600DDD5 RID: 56789 RVA: 0x00134067 File Offset: 0x00132267
		public virtual void SetFirstVectorFieldName(string _arg)
		{
			vtkParallelVectors.vtkParallelVectors_SetFirstVectorFieldName_10(base.GetCppThis(), _arg);
		}

		// Token: 0x0600DDD6 RID: 56790
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelVectors_SetSecondVectorFieldName_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the name of second vector field.
		/// </summary>
		// Token: 0x0600DDD7 RID: 56791 RVA: 0x00134077 File Offset: 0x00132277
		public virtual void SetSecondVectorFieldName(string _arg)
		{
			vtkParallelVectors.vtkParallelVectors_SetSecondVectorFieldName_11(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400102D RID: 4141
		public new const string MRFullTypeName = "Kitware.VTK.vtkParallelVectors";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400102E RID: 4142
		public new static readonly string MRClassNameKey = "class vtkParallelVectors";
	}
}
