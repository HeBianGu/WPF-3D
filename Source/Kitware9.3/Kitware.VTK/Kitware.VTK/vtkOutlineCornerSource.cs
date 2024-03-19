using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOutlineCornerSource
	/// </summary>
	/// <remarks>
	///    create wireframe outline corners around bounding box
	///
	/// vtkOutlineCornerSource creates wireframe outline corners around a user-specified
	/// bounding box.
	/// </remarks>
	// Token: 0x02000830 RID: 2096
	public class vtkOutlineCornerSource : vtkOutlineSource
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06015AF0 RID: 88816 RVA: 0x001E9C21 File Offset: 0x001E7E21
		static vtkOutlineCornerSource()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOutlineCornerSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOutlineCornerSource"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06015AF1 RID: 88817 RVA: 0x001E9C49 File Offset: 0x001E7E49
		public vtkOutlineCornerSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06015AF2 RID: 88818
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOutlineCornerSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct outline corner source with default corner factor = 0.2
		/// </summary>
		// Token: 0x06015AF3 RID: 88819 RVA: 0x001E9C58 File Offset: 0x001E7E58
		public new static vtkOutlineCornerSource New()
		{
			vtkOutlineCornerSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOutlineCornerSource.vtkOutlineCornerSource_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOutlineCornerSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct outline corner source with default corner factor = 0.2
		/// </summary>
		// Token: 0x06015AF4 RID: 88820 RVA: 0x001E9CAC File Offset: 0x001E7EAC
		public vtkOutlineCornerSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOutlineCornerSource.vtkOutlineCornerSource_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06015AF5 RID: 88821 RVA: 0x001E9CF0 File Offset: 0x001E7EF0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06015AF6 RID: 88822
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkOutlineCornerSource_GetCornerFactor_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the factor that controls the relative size of the corners
		/// to the length of the corresponding bounds
		/// </summary>
		// Token: 0x06015AF7 RID: 88823 RVA: 0x001E9CFC File Offset: 0x001E7EFC
		public virtual double GetCornerFactor()
		{
			return vtkOutlineCornerSource.vtkOutlineCornerSource_GetCornerFactor_01(base.GetCppThis());
		}

		// Token: 0x06015AF8 RID: 88824
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkOutlineCornerSource_GetCornerFactorMaxValue_02(HandleRef pThis);

		/// <summary>
		/// Set/Get the factor that controls the relative size of the corners
		/// to the length of the corresponding bounds
		/// </summary>
		// Token: 0x06015AF9 RID: 88825 RVA: 0x001E9D1C File Offset: 0x001E7F1C
		public virtual double GetCornerFactorMaxValue()
		{
			return vtkOutlineCornerSource.vtkOutlineCornerSource_GetCornerFactorMaxValue_02(base.GetCppThis());
		}

		// Token: 0x06015AFA RID: 88826
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkOutlineCornerSource_GetCornerFactorMinValue_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the factor that controls the relative size of the corners
		/// to the length of the corresponding bounds
		/// </summary>
		// Token: 0x06015AFB RID: 88827 RVA: 0x001E9D3C File Offset: 0x001E7F3C
		public virtual double GetCornerFactorMinValue()
		{
			return vtkOutlineCornerSource.vtkOutlineCornerSource_GetCornerFactorMinValue_03(base.GetCppThis());
		}

		// Token: 0x06015AFC RID: 88828
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOutlineCornerSource_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015AFD RID: 88829 RVA: 0x001E9D5C File Offset: 0x001E7F5C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOutlineCornerSource.vtkOutlineCornerSource_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06015AFE RID: 88830
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOutlineCornerSource_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015AFF RID: 88831 RVA: 0x001E9D7C File Offset: 0x001E7F7C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOutlineCornerSource.vtkOutlineCornerSource_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06015B00 RID: 88832
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOutlineCornerSource_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015B01 RID: 88833 RVA: 0x001E9D98 File Offset: 0x001E7F98
		public override int IsA(string type)
		{
			return vtkOutlineCornerSource.vtkOutlineCornerSource_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06015B02 RID: 88834
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOutlineCornerSource_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015B03 RID: 88835 RVA: 0x001E9DB8 File Offset: 0x001E7FB8
		public new static int IsTypeOf(string type)
		{
			return vtkOutlineCornerSource.vtkOutlineCornerSource_IsTypeOf_07(type);
		}

		// Token: 0x06015B04 RID: 88836
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOutlineCornerSource_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015B05 RID: 88837 RVA: 0x001E9DD4 File Offset: 0x001E7FD4
		public new vtkOutlineCornerSource NewInstance()
		{
			vtkOutlineCornerSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOutlineCornerSource.vtkOutlineCornerSource_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOutlineCornerSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06015B06 RID: 88838
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOutlineCornerSource_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015B07 RID: 88839 RVA: 0x001E9E30 File Offset: 0x001E8030
		public new static vtkOutlineCornerSource SafeDownCast(vtkObjectBase o)
		{
			vtkOutlineCornerSource vtkOutlineCornerSource = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOutlineCornerSource.vtkOutlineCornerSource_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOutlineCornerSource = (vtkOutlineCornerSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOutlineCornerSource.Register(null);
				}
			}
			return vtkOutlineCornerSource;
		}

		// Token: 0x06015B08 RID: 88840
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOutlineCornerSource_SetCornerFactor_11(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the factor that controls the relative size of the corners
		/// to the length of the corresponding bounds
		/// </summary>
		// Token: 0x06015B09 RID: 88841 RVA: 0x001E9EAF File Offset: 0x001E80AF
		public virtual void SetCornerFactor(double _arg)
		{
			vtkOutlineCornerSource.vtkOutlineCornerSource_SetCornerFactor_11(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018AA RID: 6314
		public new const string MRFullTypeName = "Kitware.VTK.vtkOutlineCornerSource";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018AB RID: 6315
		public new static readonly string MRClassNameKey = "class vtkOutlineCornerSource";
	}
}
