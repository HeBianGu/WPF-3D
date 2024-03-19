using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkInformationVector
	/// </summary>
	/// <remarks>
	///    Store zero or more vtkInformation instances.
	///
	///
	/// vtkInformationVector stores a vector of zero or more vtkInformation
	/// objects corresponding to the input or output information for a
	/// vtkAlgorithm.  An instance of this class is passed to
	/// vtkAlgorithm::ProcessRequest calls.
	/// </remarks>
	// Token: 0x02000B6B RID: 2923
	public class vtkInformationVector : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601E84E RID: 125006 RVA: 0x002B4CA0 File Offset: 0x002B2EA0
		static vtkInformationVector()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInformationVector.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInformationVector"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601E84F RID: 125007 RVA: 0x002B4CC8 File Offset: 0x002B2EC8
		public vtkInformationVector(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601E850 RID: 125008
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationVector_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E851 RID: 125009 RVA: 0x002B4CD8 File Offset: 0x002B2ED8
		public new static vtkInformationVector New()
		{
			vtkInformationVector result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationVector.vtkInformationVector_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInformationVector)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E852 RID: 125010 RVA: 0x002B4D2C File Offset: 0x002B2F2C
		public vtkInformationVector() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkInformationVector.vtkInformationVector_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601E853 RID: 125011 RVA: 0x002B4D70 File Offset: 0x002B2F70
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601E854 RID: 125012
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationVector_Append_01(HandleRef pThis, HandleRef info);

		/// <summary>
		/// Append/Remove an information object.
		/// </summary>
		// Token: 0x0601E855 RID: 125013 RVA: 0x002B4D7C File Offset: 0x002B2F7C
		public void Append(vtkInformation info)
		{
			vtkInformationVector.vtkInformationVector_Append_01(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		// Token: 0x0601E856 RID: 125014
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationVector_Copy_02(HandleRef pThis, HandleRef from, int deep);

		/// <summary>
		/// Copy all information entries from the given vtkInformation
		/// instance.  Any previously existing entries are removed.  If
		/// deep==1, a deep copy of the information structure is performed (new
		/// instances of any contained vtkInformation and vtkInformationVector
		/// objects are created).
		/// </summary>
		// Token: 0x0601E857 RID: 125015 RVA: 0x002B4DAC File Offset: 0x002B2FAC
		public void Copy(vtkInformationVector from, int deep)
		{
			vtkInformationVector.vtkInformationVector_Copy_02(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), deep);
		}

		// Token: 0x0601E858 RID: 125016
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationVector_GetInformationObject_03(HandleRef pThis, int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the vtkInformation instance stored at the given index in
		/// the vector.  The vector will automatically expand to include the
		/// index given if necessary.  Missing entries in-between will be
		/// filled with empty vtkInformation instances.
		/// </summary>
		// Token: 0x0601E859 RID: 125017 RVA: 0x002B4DDC File Offset: 0x002B2FDC
		public vtkInformation GetInformationObject(int index)
		{
			vtkInformation vtkInformation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationVector.vtkInformationVector_GetInformationObject_03(base.GetCppThis(), index, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformation = (vtkInformation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformation.Register(null);
				}
			}
			return vtkInformation;
		}

		// Token: 0x0601E85A RID: 125018
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInformationVector_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E85B RID: 125019 RVA: 0x002B4E4C File Offset: 0x002B304C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkInformationVector.vtkInformationVector_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0601E85C RID: 125020
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInformationVector_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E85D RID: 125021 RVA: 0x002B4E6C File Offset: 0x002B306C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkInformationVector.vtkInformationVector_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0601E85E RID: 125022
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationVector_GetNumberOfInformationObjects_06(HandleRef pThis);

		/// <summary>
		/// Get/Set the number of information objects in the vector.  Setting
		/// the number to larger than the current number will create empty
		/// vtkInformation instances.  Setting the number to smaller than the
		/// current number will remove entries from higher indices.
		/// </summary>
		// Token: 0x0601E85F RID: 125023 RVA: 0x002B4E88 File Offset: 0x002B3088
		public int GetNumberOfInformationObjects()
		{
			return vtkInformationVector.vtkInformationVector_GetNumberOfInformationObjects_06(base.GetCppThis());
		}

		// Token: 0x0601E860 RID: 125024
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationVector_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E861 RID: 125025 RVA: 0x002B4EA8 File Offset: 0x002B30A8
		public override int IsA(string type)
		{
			return vtkInformationVector.vtkInformationVector_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0601E862 RID: 125026
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationVector_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E863 RID: 125027 RVA: 0x002B4EC8 File Offset: 0x002B30C8
		public new static int IsTypeOf(string type)
		{
			return vtkInformationVector.vtkInformationVector_IsTypeOf_08(type);
		}

		// Token: 0x0601E864 RID: 125028
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationVector_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E865 RID: 125029 RVA: 0x002B4EE4 File Offset: 0x002B30E4
		public new vtkInformationVector NewInstance()
		{
			vtkInformationVector result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationVector.vtkInformationVector_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInformationVector)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E866 RID: 125030
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationVector_Remove_11(HandleRef pThis, HandleRef info);

		/// <summary>
		/// Append/Remove an information object.
		/// </summary>
		// Token: 0x0601E867 RID: 125031 RVA: 0x002B4F40 File Offset: 0x002B3140
		public void Remove(vtkInformation info)
		{
			vtkInformationVector.vtkInformationVector_Remove_11(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		// Token: 0x0601E868 RID: 125032
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationVector_Remove_12(HandleRef pThis, int idx);

		/// <summary>
		/// Append/Remove an information object.
		/// </summary>
		// Token: 0x0601E869 RID: 125033 RVA: 0x002B4F6F File Offset: 0x002B316F
		public void Remove(int idx)
		{
			vtkInformationVector.vtkInformationVector_Remove_12(base.GetCppThis(), idx);
		}

		// Token: 0x0601E86A RID: 125034
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationVector_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E86B RID: 125035 RVA: 0x002B4F80 File Offset: 0x002B3180
		public new static vtkInformationVector SafeDownCast(vtkObjectBase o)
		{
			vtkInformationVector vtkInformationVector = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationVector.vtkInformationVector_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationVector = (vtkInformationVector)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationVector.Register(null);
				}
			}
			return vtkInformationVector;
		}

		// Token: 0x0601E86C RID: 125036
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationVector_SetInformationObject_14(HandleRef pThis, int index, HandleRef info);

		/// <summary>
		/// Get/Set the vtkInformation instance stored at the given index in
		/// the vector.  The vector will automatically expand to include the
		/// index given if necessary.  Missing entries in-between will be
		/// filled with empty vtkInformation instances.
		/// </summary>
		// Token: 0x0601E86D RID: 125037 RVA: 0x002B5000 File Offset: 0x002B3200
		public void SetInformationObject(int index, vtkInformation info)
		{
			vtkInformationVector.vtkInformationVector_SetInformationObject_14(base.GetCppThis(), index, (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		// Token: 0x0601E86E RID: 125038
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationVector_SetNumberOfInformationObjects_15(HandleRef pThis, int n);

		/// <summary>
		/// Get/Set the number of information objects in the vector.  Setting
		/// the number to larger than the current number will create empty
		/// vtkInformation instances.  Setting the number to smaller than the
		/// current number will remove entries from higher indices.
		/// </summary>
		// Token: 0x0601E86F RID: 125039 RVA: 0x002B5030 File Offset: 0x002B3230
		public void SetNumberOfInformationObjects(int n)
		{
			vtkInformationVector.vtkInformationVector_SetNumberOfInformationObjects_15(base.GetCppThis(), n);
		}

		// Token: 0x0601E870 RID: 125040
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkInformationVector_UsesGarbageCollector_16(HandleRef pThis);

		/// <summary>
		/// Initiate garbage collection when a reference is removed.
		/// </summary>
		// Token: 0x0601E871 RID: 125041 RVA: 0x002B5040 File Offset: 0x002B3240
		public override bool UsesGarbageCollector()
		{
			return vtkInformationVector.vtkInformationVector_UsesGarbageCollector_16(base.GetCppThis()) != 0;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040020B5 RID: 8373
		public new const string MRFullTypeName = "Kitware.VTK.vtkInformationVector";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040020B6 RID: 8374
		public new static readonly string MRClassNameKey = "class vtkInformationVector";
	}
}
