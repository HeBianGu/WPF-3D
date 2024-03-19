using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCountFaces
	/// </summary>
	/// <remarks>
	///    Add a cell data array containing the number of faces
	/// per cell.
	///
	///
	/// This filter adds a cell data array containing the number of faces per cell.
	/// </remarks>
	// Token: 0x02000887 RID: 2183
	public class vtkCountFaces : vtkPassInputTypeAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06016AC2 RID: 92866 RVA: 0x001FE42E File Offset: 0x001FC62E
		static vtkCountFaces()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCountFaces.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCountFaces"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06016AC3 RID: 92867 RVA: 0x001FE456 File Offset: 0x001FC656
		public vtkCountFaces(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06016AC4 RID: 92868
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCountFaces_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016AC5 RID: 92869 RVA: 0x001FE464 File Offset: 0x001FC664
		public new static vtkCountFaces New()
		{
			vtkCountFaces result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCountFaces.vtkCountFaces_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCountFaces)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016AC6 RID: 92870 RVA: 0x001FE4B8 File Offset: 0x001FC6B8
		public vtkCountFaces() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCountFaces.vtkCountFaces_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06016AC7 RID: 92871 RVA: 0x001FE4FC File Offset: 0x001FC6FC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06016AC8 RID: 92872
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCountFaces_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016AC9 RID: 92873 RVA: 0x001FE508 File Offset: 0x001FC708
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCountFaces.vtkCountFaces_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06016ACA RID: 92874
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCountFaces_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016ACB RID: 92875 RVA: 0x001FE528 File Offset: 0x001FC728
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCountFaces.vtkCountFaces_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06016ACC RID: 92876
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCountFaces_GetOutputArrayName_03(HandleRef pThis);

		/// <summary>
		/// The name of the new output array containing the face counts.
		/// </summary>
		// Token: 0x06016ACD RID: 92877 RVA: 0x001FE544 File Offset: 0x001FC744
		public virtual string GetOutputArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkCountFaces.vtkCountFaces_GetOutputArrayName_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06016ACE RID: 92878
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCountFaces_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016ACF RID: 92879 RVA: 0x001FE580 File Offset: 0x001FC780
		public override int IsA(string type)
		{
			return vtkCountFaces.vtkCountFaces_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06016AD0 RID: 92880
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCountFaces_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016AD1 RID: 92881 RVA: 0x001FE5A0 File Offset: 0x001FC7A0
		public new static int IsTypeOf(string type)
		{
			return vtkCountFaces.vtkCountFaces_IsTypeOf_05(type);
		}

		// Token: 0x06016AD2 RID: 92882
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCountFaces_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016AD3 RID: 92883 RVA: 0x001FE5BC File Offset: 0x001FC7BC
		public new vtkCountFaces NewInstance()
		{
			vtkCountFaces result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCountFaces.vtkCountFaces_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCountFaces)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06016AD4 RID: 92884
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCountFaces_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016AD5 RID: 92885 RVA: 0x001FE618 File Offset: 0x001FC818
		public new static vtkCountFaces SafeDownCast(vtkObjectBase o)
		{
			vtkCountFaces vtkCountFaces = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCountFaces.vtkCountFaces_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCountFaces = (vtkCountFaces)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCountFaces.Register(null);
				}
			}
			return vtkCountFaces;
		}

		// Token: 0x06016AD6 RID: 92886
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCountFaces_SetOutputArrayName_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// The name of the new output array containing the face counts.
		/// </summary>
		// Token: 0x06016AD7 RID: 92887 RVA: 0x001FE697 File Offset: 0x001FC897
		public virtual void SetOutputArrayName(string _arg)
		{
			vtkCountFaces.vtkCountFaces_SetOutputArrayName_09(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400196F RID: 6511
		public new const string MRFullTypeName = "Kitware.VTK.vtkCountFaces";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001970 RID: 6512
		public new static readonly string MRClassNameKey = "class vtkCountFaces";
	}
}
